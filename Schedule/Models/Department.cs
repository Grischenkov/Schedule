using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Foreign keys
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        //Foreign relations
        public List<Teacher> Teachers { get; set; }
    }
}
