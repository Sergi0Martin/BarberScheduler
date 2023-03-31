using BarberScheduler.Infrastructure.PostgreSQL.MartenDB.Configuration;
using BarberScheduler.Infrastructure.PostgreSQL.MartenDB.Configuration.SessionFactory;
using Marten;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BarberScheduler.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureMartenForDocumentDB(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMarten(new CustomStoreOptions(configuration))
            .BuildSessionsWith<ScopedSessionFactory>(ServiceLifetime.Scoped)
            .OptimizeArtifactWorkflow()
            .InitializeWith();
            //.AssertDatabaseMatchesConfigurationOnStartup();

        services.AddScoped<ISessionFactory, ScopedSessionFactory>();
        services.AddScoped<QuerySession>(sp => new(Guid.NewGuid()));

        return services;
    }
}
