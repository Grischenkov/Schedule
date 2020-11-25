using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public int Period { get; set; }

        public string StartDate { get; set; }

        public string FinishDate { get; set; }

        //Foreign keys
        public int Group { get; set; }

        public int Teacher { get; set; }

        public string Lesson { get; set; }
    }
}
