using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockStudent : IStudent
    {
        private readonly IGroup _group = new MockGroup();

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents =>
            new List<Student>
            {
                new Student
                {
                    Id = 0, 
                    Name = "Test", 
                    Surname = "Student", 
                    MiddleName = "User", 
                    Mail = "nikita@grishchenkov.ru", 
                    Password = "qwerty", 
                    Group = _group.GetGroup(id: 4)
                }
            };
    }
}
