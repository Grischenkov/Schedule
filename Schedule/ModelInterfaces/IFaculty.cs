using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface IFaculty
    {
        public Faculty GetFaculty(int id);

        public IEnumerable<Faculty> GetFaculties { get; }
    }
}
