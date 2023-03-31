using BarberScheduler.Application.Commands;
using Microsoft.OpenApi.Models;
using Serilog;

namespace BarberScheduler.API;

public static class BarberSchedulerExtensions
{
    public static WebApplicationBuilder ConfigureApplicationLogger(this WebApplicationBuilder builder)
    {
        var applicationLogger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();

        builder.Host.UseSerilog(applicationLogger);

        return builder;
    }

    public static IServiceCollection ConfigureOpenAPI(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
         {
             // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
             options.SwaggerDoc("v1", new OpenApiInfo
             {
                 Version = "v1",
                 Title = "BarberScheduler API",
             });
         });

        return services;
    }

    public static IServiceCollection AddMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateUserCommand>());

        return services;
    }
}
