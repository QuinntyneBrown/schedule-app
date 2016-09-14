using ScheduleApp.Services;
using Microsoft.Practices.Unity;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ScheduleApp.ContentModels
{    
    public class ChannelListingPageContentModel: IChannelListingPageContentModel
    {
        [InjectionConstructor]
        public ChannelListingPageContentModel(ICacheProvider cacheProvider)
        :this(cacheProvider.GetCache()){}

        public ChannelListingPageContentModel(ICache cache)
        {
            _cache = cache;
        }

        public IChannelListingPageContentModel Get()
        {
            var contentModel = new ChannelListingPageContentModel(_cache);
            
            return contentModel;
        }
		
		[JsonConverter(typeof(StringEnumConverter))]
		public ContentModelType ContentModelType { get; set; } = ContentModelType.ChannelListingPage;

        protected readonly ICache _cache;
    }
}
