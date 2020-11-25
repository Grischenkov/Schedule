﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Schedule.Models;

namespace Schedule.ModelInterfaces
{
    public interface IClass
    {
        public Class GetClass(int id);

        public IEnumerable<Class> GetClasses { get; }
    }
}
