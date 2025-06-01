﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerSalary.Entities
{
    internal class Department
    {
        public string Name { get; private set; }

        public Department()
        {
            
        }

        public Department(string name)
        {
            Name = name;
        }

    }
}
