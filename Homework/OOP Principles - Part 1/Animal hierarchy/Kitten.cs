using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Kitten:Cat, ISound
    {
        public Kitten(string name, int age, SexType sex = SexType.female) : base(name, age, sex)
        {
            
        }
    }
}
