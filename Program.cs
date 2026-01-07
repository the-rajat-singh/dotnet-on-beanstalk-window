using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddRazorPages();

var app = builder.Build();

// IMPORTANT: This fixes 403 on "/"
app.MapGet("/", () => "✅ Notes App is running successfully on Elastic Beanstalk");

// Optional example endpoint
app.MapGet("/health", () => Results.Ok("Healthy"));

// Static files (wwwroot)
app.UseStaticFiles();

// Razor Pages (if you add UI later)
app.MapRazorPages();

app.Run();

