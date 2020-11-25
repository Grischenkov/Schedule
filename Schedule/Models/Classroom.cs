using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Classroom
    {
        public string Id { get; set; }

        //Foreign relations
        public List<Class> Classes { get; set; }
    }
}
