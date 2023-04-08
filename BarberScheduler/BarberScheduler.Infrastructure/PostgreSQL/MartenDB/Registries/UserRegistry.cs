using BarberScheduler.Domain.Aggregates.Users;
using Marten;

namespace BarberScheduler.Infrastructure.PostgreSQL.MartenDB.Registries;

internal sealed class UserRegistry : MartenRegistry
{
    public UserRegistry()
    {
        For<User>()
            .Index(x => x.Id)
            .Duplicate(x => x.UserName)
            .DocumentAlias("Users");
    }
}