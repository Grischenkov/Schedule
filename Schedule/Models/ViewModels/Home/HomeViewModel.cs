using System;
using Schedule.ModelInterfaces;
using Schedule.ModelMocks;

namespace Schedule.Models.ViewModels.Home
{
    public class HomeViewModel : UserViewModel
    {
        private readonly IClass _class = new MockClass();
        
        private string _faculty = null;
        private string _course = null;
        private string _group = null;

        private int _id;

        public string ViewType { get; set; }

        public int ClassId
        {
            get => _id;
            set
            {
                _id = value;
                Class = _class.GetClass(_id);
            }
        }

        public Class Class { get; private set; }
        
        public DateTime Date { get; set; } = DateTime.Today;

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
                    DownloadDisplay = "none";
                }
                else
                {
                    DownloadDisplay = "block";
                }
            }
        }

        public string FacultyDisplay => "block";

        public string CourseDisplay { get; private set; }

        public string GroupDisplay { get; private set; }

        public string DownloadDisplay { get; private set; }

        public Class GetClass => _class.GetClass(ClassId);
    }
}