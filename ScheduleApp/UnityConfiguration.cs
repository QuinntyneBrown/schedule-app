using ScheduleApp.Services;
using ScheduleApp.Utilities;
using Microsoft.Practices.Unity;
using ScheduleApp.ContentModels;
using ScheduleApp.Clients;
using ScheduleApp.Configuration;

namespace ScheduleApp
{
    public class UnityConfiguration
    {
        public static IUnityContainer GetContainer()
        {
            var container = new UnityContainer();            
            container.RegisterType<ILoggerFactory, LoggerFactory>();
            container.RegisterType<ICacheProvider, CacheProvider>();
            container.RegisterType<ILogger, Logger>();

            container.RegisterType<IContentBackendServiceClient, ContentBackendServiceClient>();
            container.RegisterType<IRotatorBackendServiceClient, RotatorBackendServiceClient>();
            container.RegisterType<IScheduleBackendServiceClient, ScheduleBackendServiceClient>();
            container.RegisterType<IChannelListingBackendServiceClient, ChannelListingBackendServiceClient>();

            container.RegisterType<ILandingPageContentModel, LandingPageContentModel>();
            container.RegisterType<IAppShellContentModel, AppShellContentModel>();
            container.RegisterType<ISchedulePageContentModel, SchedulePageContentModel>();
            container.RegisterType<IChannelListingPageContentModel, ChannelListingPageContentModel>();

            container.RegisterInstance(AppConfiguration.Config);

            return container;
        }
    }
}
