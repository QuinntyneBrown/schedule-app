using ScheduleApp.Services;
using Microsoft.Practices.Unity;
using ScheduleApp.Clients;
using ScheduleApp.Clients.Models;
using System.Collections.Generic;

namespace ScheduleApp.ContentModels
{    
    public class LandingPageContentModel: ILandingPageContentModel
    {
        [InjectionConstructor]
        public LandingPageContentModel(ICacheProvider cacheProvider, 
            IContentBackendServiceClient contentBackendServiceClient,
            IRotatorBackendServiceClient rotatorBackendServiceClient)
        :this(cacheProvider.GetCache(), contentBackendServiceClient, rotatorBackendServiceClient) {}

        public LandingPageContentModel(ICache cache, IContentBackendServiceClient contentBackendServiceClient, IRotatorBackendServiceClient rotatorBackendServiceClient)
        {
            _cache = cache;
            _rotatorBackendServiceClient = rotatorBackendServiceClient;
            _contentBackendServiceClient = contentBackendServiceClient;
        }

        public LandingPageContentModel() { }

        public ILandingPageContentModel Get()
        {
            var contentModel = new LandingPageContentModel();            
            return contentModel;
        }

        public ICollection<RotatorItem> RotatorItems { get; set; } = new HashSet<RotatorItem>();
        public ICollection<ContentItem> ContentItems { get; set; } = new HashSet<ContentItem>();

        public ContentModelType ContentModelType { get; set; } = ContentModelType.LandingPage;

        protected readonly ICache _cache;
        protected readonly IRotatorBackendServiceClient _rotatorBackendServiceClient;
        protected readonly IContentBackendServiceClient _contentBackendServiceClient;
    }
}
