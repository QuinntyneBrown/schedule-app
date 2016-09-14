using ScheduleApp.ContentModels;
using System.Web.Http;

namespace ScheduleApp.Controllers
{
    public class ContentController: ApiController
    {
        public ContentController(ILandingPageContentModel landingPageContentModel, 
            IAppShellContentModel appShellContentModel,
            ISchedulePageContentModel schedulePageContentModel)
        {
            _landingPageContentModel = landingPageContentModel;
            _appShellContentModel = appShellContentModel;
            _schedulePageContentModel = schedulePageContentModel;
        }

        [HttpGet]
        public IHttpActionResult Landing() => Ok(_landingPageContentModel.Get());

        [HttpGet]
        public IHttpActionResult AppShell() => Ok(_appShellContentModel.Get());

        protected readonly ILandingPageContentModel _landingPageContentModel;
        protected readonly IAppShellContentModel _appShellContentModel;
        protected readonly ISchedulePageContentModel _schedulePageContentModel;
    }
}
