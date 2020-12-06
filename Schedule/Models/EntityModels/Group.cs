using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Group
    {
        public string Id { get; set; }
        
        //Foreign keys
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        //Foreign relations
        public List<Student> Students { get; set; }

        public List<Class> Classes { get; set; }

        public List<Schedule> Schedules { get; set; }
    }
}
