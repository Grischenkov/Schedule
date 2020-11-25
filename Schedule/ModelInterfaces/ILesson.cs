using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface ILesson
    {
        public Lesson GetLesson(string id);

        public IEnumerable<Lesson> GetLessons { get; }
    }
}
