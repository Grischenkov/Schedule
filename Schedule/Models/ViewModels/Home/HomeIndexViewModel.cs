using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.ModelMocks;

namespace Schedule.Models.ViewModels.Home
{
    public sealed class HomeIndexViewModel : HomeViewModel
    {
        private readonly IClass _class = new MockClass();
        private readonly IDay _day = new MockDay();

        public DateTime MinDate { get; } = DateTime.Today.Month > 6 ? new DateTime(DateTime.Today.Year, 9, 1) : new DateTime(DateTime.Today.Year, 2, 1);

        public DateTime MaxDate { get; } = DateTime.Today.Month > 6 ? new DateTime(DateTime.Today.Year, 12, 31) : new DateTime(DateTime.Today.Year, 2, 31);

        public IEnumerable<Day> GetDays => _day.GetDays;
        
        public IEnumerable<Class> GetClassesOnDay(DateTime date, string groupId)
        {
            IEnumerable<Class> classes = _class.GetClasses;
            List<Class> newClasses = classes.Where(_class => _class.DateTime.ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy") && _class.Group.Id == groupId).ToList();

            newClasses.Sort(delegate (Class x, Class y)
            {
                if (x.DateTime == null && y.DateTime == null) return 0;
                else if (x.DateTime == null) return -1;
                else if (y.DateTime == null) return 1;
                else return x.DateTime.CompareTo(y.DateTime);
            });

            return newClasses;
        }
    }
}
