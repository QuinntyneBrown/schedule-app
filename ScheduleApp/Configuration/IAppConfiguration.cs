namespace ScheduleApp.Configuration
{
    public interface IAppConfiguration
    {
        string ScheduleBackendServiceBaseUri { get; set; }
        string RotatorBackendServiceBaseUri { get; set; }
        string ContentBackendServiceBaseUri { get; set; }
        string ChannelBackendServiceBaseUri { get; set; }
    }
}
