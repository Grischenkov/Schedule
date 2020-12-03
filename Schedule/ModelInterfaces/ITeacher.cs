using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface ITeacher
    {
        public Teacher GetTeacher(int id);

        public IEnumerable<Teacher> GetTeachers { get; }

        public void UpdateTeacher(Teacher teacher);
    }
}
