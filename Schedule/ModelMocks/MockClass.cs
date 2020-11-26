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
        private readonly IGroup _group = new MockGroup();
        private readonly ITeacher _teacher = new MockTeacher();
        private readonly IClassroom _classroom = new MockClassroom();
        private readonly ISchedule _schedule = new MockSchedule();

        public Class GetClass(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> GetClasses =>
            new List<Class>
            {
                new Class()
                {
                    Id = 1,
                    DateTime = "25/11/2020 " + _schedule.GetSchedules.First().Lesson.StartTime,
                    IsCanceled = false,
                    NewDateTime = null,
                    Group = _group.GetGroup(id: 485),
                    Teacher = _teacher.GetTeachers.First(),
                    Schedule = _schedule.GetSchedules.First(),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                }, 
                new Class()
                {
                    Id = 2,
                    DateTime = "25/11/2020 " + _schedule.GetSchedules.First().Lesson.StartTime,
                    IsCanceled = false,
                    NewDateTime = null,
                    Group = _group.GetGroup(id: 484),
                    Teacher = _teacher.GetTeachers.First(),
                    Schedule = _schedule.GetSchedules.First(),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Class()
                {
                    Id = 1,
                    DateTime = "02/12/2020 " + _schedule.GetSchedules.First().Lesson.StartTime,
                    IsCanceled = false,
                    NewDateTime = null,
                    Group = _group.GetGroup(id: 485),
                    Teacher = _teacher.GetTeachers.First(),
                    Schedule = _schedule.GetSchedules.First(),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                },
                new Class()
                {
                    Id = 2,
                    DateTime = "02/12/2020 " + _schedule.GetSchedules.First().Lesson.StartTime,
                    IsCanceled = false,
                    NewDateTime = null,
                    Group = _group.GetGroup(id: 484),
                    Teacher = _teacher.GetTeachers.First(),
                    Schedule = _schedule.GetSchedules.First(),
                    Classroom = _classroom.GetClassroom(id: "КАФ. САПРиУ")
                }
            };
    }
}
