using BarberScheduler.Domain.Aggregates.Users;
using Baseline.Reflection;
using Marten;

namespace BarberScheduler.Reads.Queries;

public sealed class UsersQueries
{
    public IQuerySession _querySession;
    public IDocumentStore _documentStore;

    public UsersQueries(IQuerySession querySession, IDocumentStore documentStore)
    {
        _querySession = querySession;
        _documentStore = documentStore;
    }

    public async Task<User?> GetUserByIdAsync(Guid userId)
    {
        await using var session = _documentStore.OpenSession();
        var user = new User("Frodo", "Bolson", "Bolson2", true);
        session.Store(user);
        await session.SaveChangesAsync();

        // Option 1
        var user_option1 = await _querySession.Query<User>()
            .Where(u => u.Id == user.Id)
            .SingleAsync();

        // Option 2
        var user_option2 = await _querySession.LoadAsync<User>(user.Id);

        // Option 3 (return json)
        var user_option3 = await _querySession.Json.FindByIdAsync<User>(user.Id);

        return user_option2;
        // utilizar un mapper para cambiar el User a UserViewModel?
    }
}