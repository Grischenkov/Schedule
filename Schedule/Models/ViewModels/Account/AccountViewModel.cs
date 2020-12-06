using System.Collections.Generic;
using System.Linq;
using Schedule.ModelInterfaces;
using Schedule.ModelMocks;

namespace Schedule.Models.ViewModels.Account
{
    public class AccountViewModel : UserViewModel
    {
        private readonly IFaculty @faculty = new MockFaculty();
        private readonly ICourse @course = new MockCourse();
        private readonly IGroup @group = new MockGroup();

        private string _faculty = null;
        private string _course = null;
        private string _group = null;

        public string Faculty
        {
            get => string.IsNullOrEmpty(_faculty) ? "Выберите факультет" : _faculty;
            set
            {
                _faculty = value;
                if (string.IsNullOrEmpty(value) || value == "Выберите факультет")
                {
                    CourseDisplay = "none";
                }
                else
                {
                    CourseDisplay = "block";
                }
            }
        }

        public string Course
        {
            get => string.IsNullOrEmpty(_course) ? "Выберите курс" : _course;
            set
            {
                _course = value;
                if (string.IsNullOrEmpty(value) || value == "Выберите курс")
                {
                    GroupDisplay = "none";
                }
                else
                {
                    GroupDisplay = "block";
                }
            }
        }

        public string Group
        {
            get => string.IsNullOrEmpty(_group) ? "Выберите группу" : _group;
            set
            {
                _group = value;
                if (string.IsNullOrEmpty(value) || value == "Выберите группу")
                {
                    ContentDisplay = "none";
                }
                else
                {
                    ContentDisplay = "block";
                }
            }
        }

        public string FacultyDisplay => "block";

        public string CourseDisplay { get; private set; }

        public string GroupDisplay { get; private set; }

        public IEnumerable<Faculty> GetFaculties => @faculty.GetFaculties;

        public IEnumerable<Course> GetCourses => @course.GetCourses;

        public IEnumerable<Group> GetGroups(string facultyName, string courseName)
        {
            IEnumerable<Group> groups = @group.GetGroups;
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

        public string ContentDisplay { get; private set; }
    }
}
