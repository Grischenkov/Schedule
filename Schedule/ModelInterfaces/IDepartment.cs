using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface IDepartment
    {
        public Department GetDepartment(int id);

        public IEnumerable<Department> GetDepartments { get; }
    }
}
