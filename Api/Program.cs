using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TeamFive.DataStorage;
using TeamFive.Services.Users;
using TeamFive.Services.Tokens;
using TeamFive.Services.Instruments;
using TeamFive.Services.Instructors;
using TeamFive.Services.Lessons;
using TeamFive.Enums;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IInstrumentService, InstrumentService>();
builder.Services.AddScoped<ILessonService, LessonService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();

builder.Configuration.AddJsonFile("appsettings.Secrets.json", optional: true, reloadOnChange: true);

string connectionString;
if (builder.Environment.IsProduction())
{
    connectionString = builder.Configuration["ConnectionStrings:AwsConnection"]!;
}
else
{
    connectionString = builder.Configuration["ConnectionStrings:LocalConnection"]!;
}

string? encKey = builder.Configuration["Jwt:SecretKey"];

if (string.IsNullOrEmpty(encKey) || encKey.Length < 32)
{
    throw new InvalidOperationException("Jwt Secret is Invalid or Missing.");
}

byte[] key = Encoding.ASCII.GetBytes(encKey);

builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
	.AddJwtBearer("Bearer", options =>
	{

		options.RequireHttpsMetadata = false;
		options.SaveToken = false;
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(key),
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
			ClockSkew = TimeSpan.Zero
		};
	}
);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("TEACHER", policy => policy.RequireClaim(ClaimTypes.Role, ((int)RoleType.TEACHER).ToString()));
    options.AddPolicy("STUDENT", policy => policy.RequireClaim(ClaimTypes.Role, ((int)RoleType.STUDENT).ToString()));
    options.AddPolicy("SUPERUSER", policy => policy.RequireClaim(ClaimTypes.Role, ((int)RoleType.SUPERUSER).ToString()));
});

builder.Services.AddDbContext<DBContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigins",
    builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigins");

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();


if (app.Environment.IsProduction())
{
    app.MapFallbackToController("Production", "Public");
}
else
{
    app.MapFallbackToController("Index", "Public");
}


app.Run();
