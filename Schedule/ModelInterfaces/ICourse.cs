using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface ICourse
    {
        public Course GetCourse(int id);

        public IEnumerable<Course> GetCourses { get; }
    }
}
