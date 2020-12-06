using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.ModelMocks;

namespace Schedule.Models.ViewModels.Home
{
    public sealed class HomeLayoutViewModel : HomeViewModel
    {
        private readonly IFaculty _faculty = new MockFaculty();
        private readonly ICourse _course = new MockCourse();
        private readonly IGroup _group = new MockGroup();

        public string Title => "Расписание занятий";
        
        public IEnumerable<Faculty> GetFaculties => _faculty.GetFaculties;

        public IEnumerable<Course> GetCourses => _course.GetCourses;

        public IEnumerable<Group> GetGroups(string facultyName, string courseName)
        {
            IEnumerable<Group> groups = _group.GetGroups;
            List<Group> newGroups = groups.Where(_group => _group.Faculty.Name == facultyName && _group.Course.Name == courseName).ToList();

            newGroups.Sort(delegate (Group x, Group y)
            {
                if (x.Id == null && y.Id == null) return 0;
                else if (x.Id == null) return -1;
                else if (y.Id == null) return 1;
                else return x.Id.CompareTo(y.Id);
            });

            return newGroups;
        }
    }
}
