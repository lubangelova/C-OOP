﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Tomcat:Cat, ISound
    {
        public Tomcat(string name, int age, SexType sex = SexType.male) : base(name, age, sex)
        {

        }

        
    }
}
