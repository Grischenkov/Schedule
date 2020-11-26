using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Foreign relations
        public List<Group> Groups { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
