using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockFaculty : IFaculty
    {
        public Faculty GetFaculty(int id)
        {
            foreach (var faculty in GetFaculties.ToList().Where(faculty => faculty.Id == id))
            {
                return faculty;
            }

            throw new NullReferenceException();
        }

        public IEnumerable<Faculty> GetFaculties =>
            new List<Faculty>
            {
                new Faculty
                {
                    Id = 1, 
                    Name = "1 ФАКУЛЬТЕТ"
                },
                new Faculty
                {
                    Id = 2, 
                    Name = "2 ФАКУЛЬТЕТ"
                },
                new Faculty
                {
                    Id = 3, 
                    Name = "3 ФАКУЛЬТЕТ"
                },
                new Faculty
                {
                    Id = 4, 
                    Name = "4 ФАКУЛЬТЕТ"
                },
                new Faculty
                {
                    Id = 5, 
                    Name = "5 ФАКУЛЬТЕТ"
                },
                new Faculty
                {
                    Id = 6, 
                    Name = "6 ФАКУЛЬТЕТ"
                }
            };
    }
}
