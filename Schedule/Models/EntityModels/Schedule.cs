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

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        //Foreign keys
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public string LessonId { get; set; }
        public virtual Lesson Lesson { get; set; }
        
        public string DayId { get; set; }
        public virtual Day Day { get; set; }

        public string ClassroomId { get; set; }
        public virtual Classroom Classroom { get; set; }

        //Foreign relations
        public List<Class> Classes { get; set; }
    }
}
