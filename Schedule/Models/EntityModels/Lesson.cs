using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Lesson
    {
        public string Id { get; set; }

        public DateTime StartTime { get; set; }

        //Foreign relations
        public List<Schedule> Schedules { get; set; }
    }
}
