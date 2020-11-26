using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockDay : IDay
    {
        public Day GetDay(int id)
        {
            foreach (var day in GetDays.ToList().Where(day => day.Id == id))
            {
                return day;
            }

            throw new NullReferenceException();
        }

        public IEnumerable<Day> GetDays =>
            new List<Day>
            {
                new Day
                {
                    Id = 1,
                    Name = "Понедельник"
                },
                new Day
                {
                    Id = 2,
                    Name = "Вторник"
                },
                new Day
                {
                    Id = 3,
                    Name = "Среда"
                },
                new Day
                {
                    Id = 4,
                    Name = "Четверг"
                },
                new Day
                {
                    Id = 5,
                    Name = "Пятница"
                }
            };
    }
}
