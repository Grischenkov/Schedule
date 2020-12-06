using System.Collections.Generic;
using Schedule.ModelInterfaces;
using Schedule.ModelMocks;

namespace Schedule.Models.ViewModels.Home
{
    public sealed class HomeClassViewModel : HomeViewModel
    {
        private readonly ILesson _lesson = new MockLesson();

        public IEnumerable<Lesson> GetLessons => _lesson.GetLessons;
    }
}
