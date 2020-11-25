using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class TeacherToDepartment
    {
        //Foreign keys
        public int Teacher { get; set; }

        public int Department { get; set; }
    }
}
