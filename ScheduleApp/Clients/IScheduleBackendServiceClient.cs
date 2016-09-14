using ScheduleApp.Clients.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleApp.Clients
{
    public interface IScheduleBackendServiceClient
    {
        Task<ICollection<ScheduleItem>> GetItemsAsync(DateTime currentDate);
    }
}
