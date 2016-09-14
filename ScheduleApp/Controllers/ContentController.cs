using ScheduleApp.ContentModels;
using System.Web.Http;

namespace ScheduleApp.Controllers
{
    [RoutePrefix("api/content")]
    public class ContentController: ApiController
    {
        public ContentController(
            IChannelListingPageContentModel channelListingPageContentModel,
            ILandingPageContentModel landingPageContentModel, 
            IAppShellContentModel appShellContentModel,
            ISchedulePageContentModel schedulePageContentModel)
        {
            _channelListingPageContentModel = channelListingPageContentModel;
            _landingPageContentModel = landingPageContentModel;
            _appShellContentModel = appShellContentModel;
            _schedulePageContentModel = schedulePageContentModel;
        }

        [HttpGet]
        [Route("landing")]
        public IHttpActionResult Landing() => Ok(_landingPageContentModel.Get());

        [HttpGet]
        [Route("schedule")]
        public IHttpActionResult Schedule() => Ok(_schedulePageContentModel.Get());

        [HttpGet]
        [Route("channellisting")]
        public IHttpActionResult ChannelListing() => Ok(_channelListingPageContentModel.Get());

        [HttpGet]
        [Route("appshell")]
        public IHttpActionResult AppShell() => Ok(_appShellContentModel.Get());

        protected readonly IChannelListingPageContentModel _channelListingPageContentModel;
        protected readonly ILandingPageContentModel _landingPageContentModel;
        protected readonly IAppShellContentModel _appShellContentModel;
        protected readonly ISchedulePageContentModel _schedulePageContentModel;
        
    }
}
