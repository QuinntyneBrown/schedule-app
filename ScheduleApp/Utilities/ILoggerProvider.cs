namespace ScheduleApp.Utilities
{
    public interface ILoggerProvider
    {
        ILogger CreateLogger(string name);
    }
}
