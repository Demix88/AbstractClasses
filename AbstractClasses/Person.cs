﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Person
    {
        public string FirstName = "Dave";
        public string LastName = "Robinson";

        public abstract void SayName();

    }
}
