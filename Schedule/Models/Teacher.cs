using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string MiddleName { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        //Foreign keys
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        //Foreign relations
        public List<Class> Classes { get; set; }

        public List<Schedule> Schedules { get; set; }

        public List<Department> Departments { get; set; }
    }
}
