using Microsoft.EntityFrameworkCore;
using TeamFive.DataStorage;
using TeamFive.Services.Users;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserService, UserService>();

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

builder.Services.AddDbContext<DBContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddCors();

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

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
	name: "Index",
	pattern: "{*url}",
	defaults: new { controller = "Public", action = "Index" }
);

app.Run();
