using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduleApp.Services
{
    public interface ICacheProvider
    {
        ICache GetCache();
    }
}
