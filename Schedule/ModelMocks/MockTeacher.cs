using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockTeacher : ITeacher
    {
        private readonly IFaculty _faculty = new MockFaculty();

        public Teacher GetTeacher(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Teacher> GetTeachers =>
            new List<Teacher>
            {
                new Teacher
                {
                    Id = 0, 
                    Name = "Test", 
                    Surname = "Teacher", 
                    MiddleName = "User", 
                    Mail = "nikita.grishenkov@gmail.com", 
                    Password = "qwerty", 
                    Faculty = _faculty.GetFaculty(id: 4)
                }
            };
    }
}
