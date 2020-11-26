using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;

namespace Schedule.ModelMocks
{
    public class MockSchedule : ISchedule
    {
        private readonly IGroup _group = new MockGroup();
        private readonly ITeacher _teacher = new MockTeacher();
        private readonly ILesson _lesson = new MockLesson();
        private readonly IDay _day = new MockDay();

        public Models.Schedule GetSchedule(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Schedule> GetSchedules =>
            new List<Models.Schedule>
            {
                new Models.Schedule
                {
                    Id = 1,
                    Subject = "Средства визуализации данных",
                    Period = 0,
                    StartDate = "01/09/2020",
                    FinishDate = "31/12/2020",
                    Group = _group.GetGroup(id: 485),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "5.2"),
                    Day = _day.GetDay(id: 4)
                },
                new Models.Schedule
                {
                    Id = 2,
                    Subject = "Средства визуализации данных",
                    Period = 0,
                    StartDate = "01/09/2020",
                    FinishDate = "31/12/2020",
                    Group = _group.GetGroup(id: 484),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "5.2"),
                    Day = _day.GetDay(id: 4)
                }
            };
    }
}
