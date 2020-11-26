using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockClassroom : IClassroom
    {
        public Classroom GetClassroom(string id)
        {
            foreach (var classroom in GetClassrooms.ToList().Where(classroom => classroom.Id == id))
            {
                return classroom;
            }

            throw new NullReferenceException();
        }

        public IEnumerable<Classroom> GetClassrooms =>
            new List<Classroom>
            {
                new Classroom
                {
                    Id = "201"
                },
                new Classroom
                {
                    Id = "КАФ. САПРиУ"
                }
            };
    }
}
