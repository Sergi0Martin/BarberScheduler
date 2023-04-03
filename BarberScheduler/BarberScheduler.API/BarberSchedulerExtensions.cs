using Serilog;

namespace BarberScheduler.API
{
    public static class BarberSchedulerExtensions
    {
        public static void ConfigureApplicationLogger(this WebApplicationBuilder builder)
        {
            var applicationLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .CreateLogger();

            builder.Host.UseSerilog(applicationLogger);
        }
    }
}
