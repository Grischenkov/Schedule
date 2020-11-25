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
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public string LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }

        //Foreign relations
        public List<Class> Classes { get; set; }
    }
}
