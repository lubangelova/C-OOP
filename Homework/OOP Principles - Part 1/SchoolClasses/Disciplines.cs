using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Disciplines : IComment
    {
        private List<string> comments=new List<string>();
     

        public Disciplines(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
        }
        public string Name { get; private set; }
        public int NumberOfExercises { get; private set; }
        public int NumberOfLectures { get; private set; }

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
            return $"{this.Name}, number of lectures: { this.NumberOfLectures}, number of exercises: {this.NumberOfExercises}";
        }
    }
}
