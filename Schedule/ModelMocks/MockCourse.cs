using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockCourse : ICourse
    {
        public Course GetCourse(int id)
        {
            foreach (var course in GetCourses.ToList().Where(course => course.Id == id))
            {
                return course;
            }

            throw new NullReferenceException();
        }

        public IEnumerable<Course> GetCourses =>
            new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "1 курс"
                },
                new Course
                {
                    Id = 2,
                    Name = "2 курс"
                },
                new Course
                {
                    Id = 3,
                    Name = "3 курс"
                },
                new Course
                {
                    Id = 4,
                    Name = "4 курс"
                },
                new Course
                {
                    Id = 5,
                    Name = "5 курс"
                },
                new Course
                {
                    Id = 6,
                    Name = "6 курс"
                },
                new Course
                {
                    Id = 7,
                    Name = "Магистратура 1 курс"
                },
                new Course
                {
                    Id = 8,
                    Name = "Магистратура 2 курс"
                }
            };
    }
}
