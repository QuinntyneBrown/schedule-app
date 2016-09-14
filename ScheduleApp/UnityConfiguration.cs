using ScheduleApp.Services;
using ScheduleApp.Utilities;
using Microsoft.Practices.Unity;

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
            return container;
        }
    }
}
