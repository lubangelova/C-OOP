using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Student:People, IComment
    {
        public Student(string name, int classNumber) :base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber { get; private set; }

       
    }
}
