using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container
builder.Services.AddControllers(); // Add controller support

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()         // Allow all origins
              .AllowAnyMethod()         // Allow any HTTP method (GET, POST, etc.)
              .AllowAnyHeader();        // Allow any headers
    });
});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Enable CORS before routing
app.UseCors("AllowAllOrigins");

// Use middleware
app.UseRouting();

app.MapControllers(); // Map API controllers

app.Run();