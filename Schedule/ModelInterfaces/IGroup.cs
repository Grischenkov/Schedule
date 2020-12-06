using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface IGroup
    {
        public Group GetGroup(string id);

        public IEnumerable<Group> GetGroups { get; }

        public void AddGroup(Group group);

        public void UpdateGroup(Group group);
    }
}
