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

        public Group GetGroup(int id)
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
                    Id = 484,
                    Course = 3,
                    Faculty = _faculty.GetFaculty(id: 4)
                },
                new Group
                {
                    Id = 485,
                    Course = 3,
                    Faculty = _faculty.GetFaculty(id: 4)
                }
            };
    }
}
