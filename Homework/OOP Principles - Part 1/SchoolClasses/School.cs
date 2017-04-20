using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class School:IClass
    {
        private List<Class> classes=new List<Class>();

        public School(string name, List<Class> classes)
        {
            this.Name = name;
            this.Classes =classes;
        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            private set
            {
                this.classes = value;
            }
        }
        public string Name { get; private set; }

        public void AddClass(Class currentClass)
        {
            this.Classes.Add(currentClass);
        }

        public void RemoveClass(Class currentClass)
        {
            this.Classes.Remove(currentClass);
        }
    }
}
