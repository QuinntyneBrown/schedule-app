using ScheduleApp.Clients.Models;
using static ScheduleApp.Infrastructure.Constants;
using ScheduleApp.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ScheduleApp.Configuration;

namespace ScheduleApp.Clients
{
    public class ScheduleBackendServiceClient: IScheduleBackendServiceClient
    {
        public ScheduleBackendServiceClient(IAppConfiguration appConfiguration, ICacheProvider cacheProvider)
        {
            _appConfiguration = appConfiguration;
            _cache = cacheProvider.GetCache();
        }

        public virtual async Task<ICollection<ScheduleItem>> GetItemsAsync(DateTime currentDate) {
            return await _cache.FromCacheOrServiceAsync(() =>
            {
                var uri = $"{_appConfiguration.ScheduleBackendServiceBaseUri}/api/scheduleitem/get?appid={AppId}&currentDate={currentDate}";
                var responseMessage = new HttpClient().GetAsync($"{uri}").Result;
                return responseMessage.Content.ReadAsAsync<ICollection<ScheduleItem>>();
            }, ScheduleItemsCacheKey);
        }
        
        protected readonly IAppConfiguration _appConfiguration;
        protected readonly ICache _cache;
    }
}
