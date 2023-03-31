using BarberScheduler.Reads.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace BarberScheduler.Reads;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddQueries(this IServiceCollection services)
    {
        services.AddTransient<UsersQueries>();

        return services;
    }
}
