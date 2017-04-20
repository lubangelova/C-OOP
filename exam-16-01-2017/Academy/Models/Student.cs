using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private Track track;
        private string username;
        private IList<ICourseResult> courseResults;

        public Student(string username, Track track)
        {
            this.Username = username;
            this.Track = track;
            this.courseResults = new List<ICourseResult>();

        }
        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this.courseResults;
            }

            set
            {
                this.courseResults = value;
            }
        }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
               
                this.track = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                if (value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
                this.username = value;
            }
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Student:")
                .AppendLine(string.Format(" - Username: {0}", this.Username))
                .AppendLine(string.Format(" - Track: {0}", this.Track))
                .AppendLine(" - Course results:");
            if (this.CourseResults.Count == 0)
            {
                builder.AppendLine("  * User has no course results!");
            }
            else
            {
                builder.AppendLine(PrintCourseResults());
            }
            return builder.ToString().TrimEnd();
        }
        private string PrintCourseResults()
        {
            var builder = new StringBuilder();
            foreach (var courseResult in courseResults)
            {
                builder.AppendLine(courseResult.ToString());
            }
            return builder.ToString();

        }
    }
}
/*
* Student:
 - Username: <username>
 - Track: <track>
 - Course results:
  * User has no course results!
*/
