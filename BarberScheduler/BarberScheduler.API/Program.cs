using BarberScheduler.API;
using Microsoft.OpenApi.Models;
using Serilog;

Console.Title = "BarberScheduler Api";
var startUpLogger = new LoggerConfiguration()
    .WriteTo.File("ApplicationStartup.log")
    .CreateLogger();

try
{
var builder = WebApplication.CreateBuilder(args);
    builder.ConfigureApplicationLogger();

    builder.Services
        .AddEndpointsApiExplorer()
        .AddSwaggerGen(options =>
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "BarberScheduler API",
            });
        });

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    ////////////////


    var summaries = new[]
    {
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

    app.MapGet("/weatherforecast", (ILogger<WeatherForecast> logger) =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            ))
            .ToArray();

        logger.LogInformation("Hola mundo");
        return forecast;
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

    startUpLogger.Information($"Application startup successful");

    app.Run();
}
catch (Exception ex)
{
    startUpLogger.Fatal(ex, "Application startup failed");
    throw;
}

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
