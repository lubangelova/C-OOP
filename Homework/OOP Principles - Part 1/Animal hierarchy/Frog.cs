using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Frog:Animals,ISound
    {
        public Frog(string name, int age, SexType sex) : base(name, age, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("kva-kva"); 
        }
    }
}
