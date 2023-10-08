using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TeamFive.DataStorage;
using TeamFive.Services;
using TeamFive.Services.Users;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ITokenService, TokenService>();

builder.Configuration.AddJsonFile("appsettings.Secrets.json", optional: true, reloadOnChange: true);

string connectionString;
if (builder.Environment.IsProduction())
{
    connectionString = builder.Configuration.GetConnectionString("AwsConnection")!;
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

		options.RequireHttpsMetadata = true;
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

var app = builder.Build();

app.UseCors("AllowOrigins");

app.UseStaticFiles();

// app.UseAuthentication();

// app.UseAuthorization();

app.MapControllers();

app.MapFallbackToController("Index", "Public");

app.Run();
