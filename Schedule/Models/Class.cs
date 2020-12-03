using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Class
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsCanceled { get; set; }

        public DateTime NewDateTime { get; set; }

        //Foreign keys
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public int ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }

        public string ClassroomId { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}
