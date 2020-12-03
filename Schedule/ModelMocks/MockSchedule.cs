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
        private readonly IClassroom _classroom = new MockClassroom();

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
                    StartDate = new DateTime(2020, 9, 1),
                    FinishDate = new DateTime(2020, 12, 31),
                    Group = _group.GetGroup(id: "485"),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "5.2"),
                    Day = _day.GetDay(id: 4),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Models.Schedule
                {
                    Id = 2,
                    Subject = "Средства визуализации данных",
                    Period = 0,
                    StartDate = new DateTime(2020, 9, 1),
                    FinishDate = new DateTime(2020, 12, 31),
                    Group = _group.GetGroup(id: "485"),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "5.2"),
                    Day = _day.GetDay(id: 3),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Models.Schedule
                {
                    Id = 3,
                    Subject = "Вычислительные системы, сети и телекоммуникации",
                    Period = 0,
                    StartDate = new DateTime(2020, 9, 1),
                    FinishDate = new DateTime(2020, 12, 31),
                    Group = _group.GetGroup(id: "485"),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "4.2"),
                    Day = _day.GetDay(id: 4),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Models.Schedule
                {
                    Id = 4,
                    Subject = "Вычислительные системы, сети и телекоммуникации",
                    Period = 0,
                    StartDate = new DateTime(2020, 9, 1),
                    FinishDate = new DateTime(2020, 12, 31),
                    Group = _group.GetGroup(id: "484"),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "4.2"),
                    Day = _day.GetDay(id: 4),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Models.Schedule
                {
                    Id = 5,
                    Subject = "Средства визуализации данных",
                    Period = 0,
                    StartDate = new DateTime(2020, 9, 1),
                    FinishDate = new DateTime(2020, 12, 31),
                    Group = _group.GetGroup(id: "484"),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "5.2"),
                    Day = _day.GetDay(id: 4),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Models.Schedule
                {
                    Id = 6,
                    Subject = "Методы поддержки принятия решений",
                    Period = 0,
                    StartDate = new DateTime(2020, 9, 1),
                    FinishDate = new DateTime(2020, 12, 31),
                    Group = _group.GetGroup(id: "484"),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "2.2"),
                    Day = _day.GetDay(id: 1),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Models.Schedule
                {
                    Id = 7,
                    Subject = "Методы поддержки принятия решений",
                    Period = 0,
                    StartDate = new DateTime(2020, 9, 1),
                    FinishDate = new DateTime(2020, 12, 31),
                    Group = _group.GetGroup(id: "485"),
                    Teacher = _teacher.GetTeachers.First(),
                    Lesson = _lesson.GetLesson(id: "2.2"),
                    Day = _day.GetDay(id: 1),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                }
            };
    }
}
