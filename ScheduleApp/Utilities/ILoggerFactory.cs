using System.Collections.Generic;

namespace ScheduleApp.Utilities
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string categoryName);

        List<ILoggerProvider> GetProviders();
    }
}
