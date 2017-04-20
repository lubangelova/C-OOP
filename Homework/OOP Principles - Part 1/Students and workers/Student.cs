using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_workers
{
    public class Student : Human
    {
        private int grade;
        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value < 0 && value > 6)
                {
                    throw new ArgumentException("Grade must be between 0 and 6");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - grade:{this.Grade}";
        }
    }
}
