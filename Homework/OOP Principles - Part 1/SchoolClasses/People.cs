using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class People:IComment
    {
        private string name;
        private List<People> people = new List<People>();
        private List<string> comments = new List<string>();

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name {0}", ConstantMessages.EmptyField);
                }
                this.name = value;
            }
        }
        

        public List<string> Comments
        {
            get
            {
                return this.comments;
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

        public override string ToString()
        {
            return $"{ this.Name}";
        }
    }
}
