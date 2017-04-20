using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private int lecturesPerWeek;
        private string name;
        private IList<ILecture> lectures;
        private IList<IStudent> onlineStudents;
        private IList<IStudent> onsiteStudents;
        //TODO Extract validation

        public Course(string name, int lecturesPerWeek, DateTime startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this.StartingDate = startingDate;
            this.EndingDate = startingDate.AddDays(30);
            this.lectures = new List<ILecture>();
            this.onlineStudents = new List<IStudent>();
            this.onsiteStudents = new List<IStudent>();

        }
        public DateTime EndingDate
        {
            get;

            set;
        }

        public IList<ILecture> Lectures
        {
            get
            {
                return this.lectures;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                if (value<1 || value>7)
                {
                    throw new ArgumentException("The number of lectures per week must be between 1 and 7!");

                }
                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
              
               if (string.IsNullOrEmpty(value) || value.Length<3 || value.Length>45)
                {
                    throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
                }
                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this.onlineStudents;
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this.onsiteStudents;
            }
        }

        public DateTime StartingDate
        {
            get;

            set;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Course:")
                .AppendLine(string.Format(" - Name: {0}", this.Name))
                .AppendLine(string.Format(" - Lectures per week: {0}", this.LecturesPerWeek))
                .AppendLine(string.Format(" - Starting date: {0}", this.StartingDate))
                .AppendLine(string.Format(" - Ending date: {0}", this.EndingDate))
                .AppendLine(string.Format(" - Onsite students: {0}",this.onsiteStudents.Count))
                .AppendLine(string.Format(" - Online students: {0}", this.onlineStudents.Count))
                .AppendLine(" - Lectures:");
            if (this.Lectures.Count == 0)
            {
                builder.AppendLine("  * There are no lectures in this course!");
            }
            else
            {
            
                builder.AppendLine(PrintLectures());
            }

            return builder.ToString();
        }
        private string PrintLectures()
        {
            var builder = new StringBuilder();
            foreach (var lecture in lectures)
            {
                builder.AppendLine(lecture.ToString());
            }
            return builder.ToString();
        }
        
    }
}

 
