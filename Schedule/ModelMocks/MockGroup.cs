using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.Models;

namespace Schedule.ModelMocks
{
    public class MockGroup : IGroup
    {
        private readonly IFaculty _faculty = new MockFaculty();
        private readonly ICourse _course = new MockCourse();

        public Group GetGroup(string id)
        {
            foreach (var group in GetGroups.ToList().Where(group => group.Id == id))
            {
                return group;
            }

            throw new NullReferenceException();
        }

        public IEnumerable<Group> GetGroups =>
            new List<Group>
            {
                new Group
                {
                    Id = "484",
                    Course = _course.GetCourse(id: 3),
                    Faculty = _faculty.GetFaculty(id: 4)
                },
                new Group
                {
                    Id = "485",
                    Course = _course.GetCourse(id: 3),
                    Faculty = _faculty.GetFaculty(id: 4)
                }
            };

        public void AddGroup(Group @group)
        {
            throw new NotImplementedException();
        }

        public void UpdateGroup(Group @group)
        {
            throw new NotImplementedException();
        }
    }
}
