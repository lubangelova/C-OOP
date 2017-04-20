using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Class : IComment,IPeople
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<string> comments = new List<string>();
        private List<Student> students=new List<Student>();

        public Class(string identifier, List<Student> students, List<Teacher> teachers)
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
            this.Students = students;

        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }

        }
        public string Identifier { get; private set; }
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }

        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            private set
            {
                this.students = value;
            }
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComment(string comment)
        {
            this.Comments.Remove(comment);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }
        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }
    }
}
