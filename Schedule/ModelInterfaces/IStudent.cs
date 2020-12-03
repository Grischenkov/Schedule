using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface IStudent
    {
        public Student GetStudent(int id);

        public IEnumerable<Student> GetStudents { get; }

        public void AddStudent(Student student);

        public void UpdateStudent(Student student);
    }
}
