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
                    StartTime = "09:30"
                },
                new Lesson
                {
                    Id = "1.2", 
                    StartTime = "10:00"
                },
                new Lesson
                {
                    Id = "2.1", 
                    StartTime = "11:30"
                },
                new Lesson
                {
                    Id = "2.2", 
                    StartTime = "12:00"
                },
                new Lesson
                {
                    Id = "3.1", 
                    StartTime = "14:00"
                },
                new Lesson
                {
                    Id = "3.2", 
                    StartTime = "14:30"
                },
                new Lesson
                {
                    Id = "4.1", 
                    StartTime = "16:00"
                },
                new Lesson
                {
                    Id = "4.2", 
                    StartTime = "16:30"
                },
                new Lesson
                {
                    Id = "5.1", 
                    StartTime = "18:00"
                },
                new Lesson
                {
                    Id = "5.2", 
                    StartTime = "18:30"
                },
                new Lesson
                {
                    Id = "6.1", 
                    StartTime = "20:00"
                },
                new Lesson
                {
                    Id = "6.2", 
                    StartTime = "20:30"
                }
            };
    }
}
