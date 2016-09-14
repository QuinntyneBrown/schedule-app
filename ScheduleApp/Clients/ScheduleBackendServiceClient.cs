using System;
using System.Net.Http;

namespace ScheduleApp.Clients
{
    public class ScheduleBackendServiceClient: IScheduleBackendServiceClient
    {
        public ScheduleBackendServiceClient()
        {

        }



        protected virtual HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("");
            return httpClient;
        }
    }
}
