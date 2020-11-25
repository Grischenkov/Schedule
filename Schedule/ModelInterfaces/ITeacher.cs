using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface ITeacher
    {
        public Teacher GeTeacher(int id);

        public IEnumerable<Teacher> GeTeachers { get; }
    }
}
