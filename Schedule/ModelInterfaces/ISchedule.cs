using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.ModelInterfaces
{
    public interface ISchedule
    {
        public Models.Schedule GetSchedule(string id);

        public IEnumerable<Models.Schedule> GetSchedules { get; }
    }
}
