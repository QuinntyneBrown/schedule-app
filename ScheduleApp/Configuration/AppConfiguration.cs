using System;
using System.Configuration;

namespace ScheduleApp.Configuration
{
    public class AppConfiguration: ConfigurationSection, IAppConfiguration
    {
        [ConfigurationProperty("contentBackendServiceBaseUri")]
        public string ContentBackendServiceBaseUri
        {
            get { return (string)this["contentBackendServiceBaseUri"]; }
            set { this["contentBackendServiceBaseUri"] = value; }
        }

        [ConfigurationProperty("channelBackendServiceBaseUri")]
        public string ChannelBackendServiceBaseUri
        {
            get { return (string)this["channelBackendServiceBaseUri"]; }
            set { this["channelBackendServiceBaseUri"] = value; }
        }

        [ConfigurationProperty("rotatorBackendServiceBaseUri")]
        public string RotatorBackendServiceBaseUri
        {
            get { return (string)this["rotatorBackendServiceBaseUri"]; }
            set { this["rotatorBackendServiceBaseUri"] = value; }
        }

        [ConfigurationProperty("scheduleBackendServiceBaseUri")]
        public string ScheduleBackendServiceBaseUri
        {
            get { return (string)this["scheduleBackendServiceBaseUri"]; }
            set { this["scheduleBackendServiceBaseUri"] = value; }
        }

        public static AppConfiguration Config
        {
            get { return ConfigurationManager.GetSection("appConfiguration") as AppConfiguration; }
        }

        public static readonly Lazy<IAppConfiguration> LazyConfig = new Lazy<IAppConfiguration>(() =>
        {
            return Config as IAppConfiguration;
        }, true);
    }
}
