using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockClass : IClass
    {
        private readonly IClassroom _classroom = new MockClassroom();

        public Class GetClass(int id)
        {
            return GetClasses.ToList().FirstOrDefault(@class => @class.Id == id);
        }

        public IEnumerable<Class> GetClasses => CalcClasses();

        public DateTime MaxDate { get; } = DateTime.Today.Month > 6 ? new DateTime(DateTime.Today.Year, 12, 31) : new DateTime(DateTime.Today.Year, 2, 31);

        public IEnumerable<Class> CalcClasses()
        {
            ISchedule _schedule = new MockSchedule();
            IEnumerable<Models.Schedule> schedules = _schedule.GetSchedules;
            List<Class> classes = new List<Class>();
            int i = 1;
            foreach (var schedule in schedules)
            {
                DateTime date = schedule.StartDate.AddDays(schedule.Day.Id - (int)schedule.StartDate.Date.DayOfWeek);

                switch (schedule.Period)
                {
                    case 2:
                        date = date.AddDays(7);
                        while (date.AddDays(14) <= MaxDate.Date)
                        {
                            classes.Add(new Class
                            {
                                Id = i,
                                DateTime = new DateTime(date.Year, date.Month, date.Day, schedule.Lesson.StartTime.Hour, schedule.Lesson.StartTime.Minute, schedule.Lesson.StartTime.Second),
                                IsCanceled = false,
                                Group = schedule.Group,
                                Teacher = schedule.Teacher,
                                Schedule = schedule,
                                Classroom = schedule.Classroom
                            });
                            i++;
                            date = date.AddDays(14);
                        }

                        break;
                    case 1:
                        date = date.AddDays(0);
                        while (date.AddDays(14) <= MaxDate.Date)
                        {
                            classes.Add(new Class
                            {
                                Id = i,
                                DateTime = new DateTime(date.Year, date.Month, date.Day, schedule.Lesson.StartTime.Hour, schedule.Lesson.StartTime.Minute, schedule.Lesson.StartTime.Second),
                                IsCanceled = false,
                                Group = schedule.Group,
                                Teacher = schedule.Teacher,
                                Schedule = schedule,
                                Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                            });
                            i++;
                            date = date.AddDays(14);
                        }

                        break;
                    default:
                    {
                        while (date <= MaxDate.Date)
                        {
                            classes.Add(new Class
                            {
                                Id = i,
                                DateTime = new DateTime(date.Year, date.Month, date.Day, schedule.Lesson.StartTime.Hour, schedule.Lesson.StartTime.Minute, schedule.Lesson.StartTime.Second),
                                IsCanceled = false,
                                Group = schedule.Group,
                                Teacher = schedule.Teacher,
                                Schedule = schedule,
                                Classroom = schedule.Classroom
                            });
                            i++;
                            date = date.AddDays(7);
                        }

                        break;
                    }
                }
            }

            return classes;
        }
    }
}
