using Marten;
using Marten.Services;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace BarberScheduler.Infrastructure.PostgreSQL.MartenDB.Configuration.SessionFactory;

internal class CorrelatedMartenLogger : IMartenSessionLogger
{
    private readonly ILogger<IDocumentSession> _logger;
    private readonly QuerySession _session;

    public CorrelatedMartenLogger(ILogger<IDocumentSession> logger, QuerySession session)
    {
        _logger = logger;
        _session = session;
    }

    public void LogSuccess(NpgsqlCommand command)
    {
        LogCommand(command);
    }

    public void LogFailure(NpgsqlCommand command, Exception ex)
    {
        LogCommand(command);
    }

    public void RecordSavedChanges(IDocumentSession session, IChangeSet commit)
    {
        // Do some kind of logging using the correlation id of the ISession
    }

    public void OnBeforeExecute(NpgsqlCommand command)
    {
        LogCommand(command);
    }

    private void LogCommand(NpgsqlCommand command) => _logger.LogDebug($"Session: {_session.CorrelationId}. Executed: {command.CommandText}");
}