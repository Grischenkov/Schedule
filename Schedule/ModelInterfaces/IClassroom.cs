using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface IClassroom
    {
        public Classroom GetClassroom(string id);

        public IEnumerable<Classroom> GetClassrooms { get; }
    }
}
