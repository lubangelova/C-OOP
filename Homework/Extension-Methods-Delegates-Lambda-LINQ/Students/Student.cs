using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        private int age;
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private int groupNumber;
        private List<string> marks = new List<string>();
        private List<Student> listOfStudents=new List<Student>();
        private Group group;

        
        public Student (string firstName,string lastName,int age)
           
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName,int age, string fn, string tel, string email, List<string> marks, Group group)
            :this (firstName, lastName,age)
        {
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.Group  = group;
            
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The first name can not be a empty field");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The first name can not be a empty field");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public int Age
        {
            get
            {
               return this.age;
            }
                
             private set
            {
                if (value > 0)
                {
                    this.age=value;
                }
                else
                {
                    throw new ArgumentException("Age must be a positive number");
                }
            }     
         }
        public string FN
        {
            get
            {
                return this.fn;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The faculty number "+ConstantMessages.EmptyField);
                }
                else
                {
                    this.fn = value;
                }
            }
        }
        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                if (string.IsNullOrEmpty(value)|| string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The telephone number " +ConstantMessages.EmptyField);

                }
                else
                {
                    this.tel = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The email "+ConstantMessages.EmptyField);

                }
                else
                {
                    this.email = value;
                }
            }
        }
        public List<string> Marks

        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }
        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The group number " + ConstantMessages.PositiveNumber);
                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }
        public List<Student> ListOfStudent
        {
            get
            {
                return this.listOfStudents;
            }
        }

        public Group Group { get; private set; }
    }
}
