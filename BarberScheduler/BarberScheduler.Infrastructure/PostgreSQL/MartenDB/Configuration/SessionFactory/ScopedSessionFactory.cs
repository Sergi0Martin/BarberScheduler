using Marten;
using Microsoft.Extensions.Logging;

namespace BarberScheduler.Infrastructure.PostgreSQL.MartenDB.Configuration.SessionFactory;

internal class ScopedSessionFactory : ISessionFactory
{
    private readonly IDocumentStore _store;
    private readonly ILogger<IDocumentSession> _logger;
    private readonly QuerySession _session;

    // This is important! You will need to use the
    // IDocumentStore to open sessions
    public ScopedSessionFactory(
        IDocumentStore store,
        ILogger<IDocumentSession> logger,
        QuerySession session)
    {
        _store = store;
        _logger = logger;
        _session = session;
    }

    public IQuerySession QuerySession()
    {
        return _store.QuerySession();
    }

    public IDocumentSession OpenSession()
    {
        var session = _store.LightweightSession();

        // Replace the Marten session logger with our new
        // correlated marten logger
        session.Logger = new CorrelatedMartenLogger(_logger, _session);

        return session;
    }
}
