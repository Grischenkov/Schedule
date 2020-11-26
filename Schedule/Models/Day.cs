using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Day
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Foreign relations
        public List<Schedule> Schedules { get; set; }
    }
}
