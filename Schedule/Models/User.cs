using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Mail { get; set; } = null;

        public string Password { get; set; } = null;
        
        public bool IsTeacher { get; set; } = false;
    }
}
