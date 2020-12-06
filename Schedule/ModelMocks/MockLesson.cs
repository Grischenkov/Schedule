using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockLesson : ILesson
    {
        public Lesson GetLesson(string id)
        {
            foreach (var lesson in GetLessons.ToList().Where(lesson => lesson.Id == id))
            {
                return lesson;
            }

            throw new NullReferenceException();
        }

        public IEnumerable<Lesson> GetLessons =>
            new List<Lesson>
            {
                new Lesson
                {
                    Id = "1.1", 
                    StartTime = new DateTime(2000, 1, 1, 9, 30, 0)
                },
                new Lesson
                {
                    Id = "1.2",
                    StartTime = new DateTime(2000, 1, 1, 10, 00, 0)
                },
                new Lesson
                {
                    Id = "2.1",
                    StartTime = new DateTime(2000, 1, 1, 11, 30, 0)
                },
                new Lesson
                {
                    Id = "2.2",
                    StartTime = new DateTime(2000, 1, 1, 12, 00, 0)
                },
                new Lesson
                {
                    Id = "3.1",
                    StartTime = new DateTime(2000, 1, 1, 14, 00, 0)
                },
                new Lesson
                {
                    Id = "3.2",
                    StartTime = new DateTime(2000, 1, 1, 14, 30, 0)
                },
                new Lesson
                {
                    Id = "4.1",
                    StartTime = new DateTime(2000, 1, 1, 16, 00, 0)
                },
                new Lesson
                {
                    Id = "4.2",
                    StartTime = new DateTime(2000, 1, 1, 16, 30, 0)
                },
                new Lesson
                {
                    Id = "5.1",
                    StartTime = new DateTime(2000, 1, 1, 18, 00, 0)
                },
                new Lesson
                {
                    Id = "5.2",
                    StartTime = new DateTime(2000, 1, 1, 18, 30, 0)
                },
                new Lesson
                {
                    Id = "6.1",
                    StartTime = new DateTime(2000, 1, 1, 20, 00, 0)
                },
                new Lesson
                {
                    Id = "6.2",
                    StartTime = new DateTime(2000, 1, 1, 20, 30, 0)
                }
            };
    }
}
