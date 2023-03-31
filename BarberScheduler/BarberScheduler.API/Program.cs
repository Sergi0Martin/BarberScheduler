using BarberScheduler.API;
using BarberScheduler.API.Endpoints;
using BarberScheduler.Infrastructure;
using BarberScheduler.Reads;
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
        .AddMediatR()
        .AddQueries()
        .ConfigureMartenForDocumentDB(builder.Configuration)
        .AddEndpointsApiExplorer()
        .ConfigureOpenAPI();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.MapGroup("/api")
        .MapUsers();

    startUpLogger.Information($"Application startup successful");

    app.Run();
}
catch (Exception ex)
{
    startUpLogger.Fatal(ex, "Application startup failed");
    throw;
}