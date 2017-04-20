using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    public  class Animals:ISound
    {
        private int age;
        private string name;
        private SexType sex;
        public Animals(string name, int age,  SexType sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
        public SexType Sex
        {
            get
            {
                return this.sex;
            }
            private set
            {
                this.sex = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}- {this.Age} years old, {this.Sex}";
        }

        public static double CalculateAverageAge(IEnumerable<Animals> listOfAnimals)
        {
            var result = listOfAnimals
                .Average(a => a.Age);
            return result;
                
        }
        //public abstract void Sound();
        public virtual void Sound()
        {
            
        }
    }
}
