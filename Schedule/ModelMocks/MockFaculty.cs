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
                    Name = "Химии веществ и материалов"
                },
                new Faculty
                {
                    Id = 2, 
                    Name = "Химической и биотехнологии"
                },
                new Faculty
                {
                    Id = 3, 
                    Name = "Механический"
                },
                new Faculty
                {
                    Id = 4, 
                    Name = "Информационных технологий и управления"
                },
                new Faculty
                {
                    Id = 5, 
                    Name = "Инженерно-технологический"
                },
                new Faculty
                {
                    Id = 6, 
                    Name = "Экономики и мененджмента"
                }
            };
    }
}
