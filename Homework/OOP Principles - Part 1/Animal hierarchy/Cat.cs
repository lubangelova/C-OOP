using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public class Cat:Animals, ISound
    {
        public Cat(string name, int age, SexType sex) : base(name, age, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("miau-miau"); 
        }
    }
}
