using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Group
    {
        public int Id { get; set; }

        public int Course { get; set; }

        //Foreign keys
        public int Faculty { get; set; }
    }
}
