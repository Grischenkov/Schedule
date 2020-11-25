using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Class
    {
        public int Id { get; set; }

        public string DateTime { get; set; }

        public bool IsCanceled { get; set; }

        public string NewDateTime { get; set; }

        //Foreign keys
        public int Group { get; set; }

        public int Teacher { get; set; }

        public int Schedule { get; set; }

        public string Classroom { get; set; }
    }
}
