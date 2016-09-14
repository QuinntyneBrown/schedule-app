using System.Net.Http;

namespace ScheduleApp.Clients
{
    public class ChannelListingBackendServiceClient: IChannelListingBackendServiceClient
    {

        public HttpClient CreateHttpClient() {
            var httpClient = new HttpClient();
            return httpClient;
        }
    }
}
