using ScheduleApp.Services;
using Microsoft.Practices.Unity;
using ScheduleApp.Clients;
using ScheduleApp.Clients.Models;
using System.Collections.Generic;

namespace ScheduleApp.ContentModels
{    
    public class SchedulePageContentModel: ISchedulePageContentModel
    {
        [InjectionConstructor]
        public SchedulePageContentModel(ICacheProvider cacheProvider, IScheduleBackendServiceClient scheduleBackendServiceClient)
        :this(cacheProvider.GetCache(), scheduleBackendServiceClient) {}

        public SchedulePageContentModel(ICache cache, IScheduleBackendServiceClient scheduleBackendServiceClient)
        {
            _cache = cache;
            _scheduleBackendServiceClient = scheduleBackendServiceClient;
        }

        public SchedulePageContentModel() { }

        public ISchedulePageContentModel Get()
        {
            var contentModel = new SchedulePageContentModel();
            
            return contentModel;
        }

        public ICollection<ScheduleItem> ScheduleItems { get; set; } = new HashSet<ScheduleItem>();


        public ContentModelType ContentModelType { get; set; } = ContentModelType.SchedulePage;
        
        protected readonly ICache _cache;
        protected readonly IScheduleBackendServiceClient _scheduleBackendServiceClient;
    }
}
