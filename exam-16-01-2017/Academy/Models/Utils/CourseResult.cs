using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Enums;

namespace Academy.Models.Utils
{
    public class CourseResult : ICourseResult
    {
        private ICourse course;
        private float coursePoints;
        private float examPoints;
        private Grade grade;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints =float.Parse(examPoints);
            this.CoursePoints =float.Parse(coursePoints);
        }

        public ICourse Course
        {
            get
            {
                return this.course;
            }
            protected set
            {
                this.course = value;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }
            protected set
            {
                if (value<0 || value>125)
                {
                    throw new ArgumentException("Course result's course points should be between 0 and 125!");
                }
                this.coursePoints = value;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
            protected set
            {
                if (value<0 || value>1000)
                {
                    throw new ArgumentException("Course result's exam points should be between 0 and 1000!");
                }
                this.examPoints = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }
            protected set
            {
                if (this.ExamPoints>=65 || this.CoursePoints>=75)
                {
                    this.grade = Grade.Excellent;
                }
                else if ((this.ExamPoints>=30 && this.ExamPoints<60) || (this.CoursePoints>=45 && this.CoursePoints<75))
                {
                    this.grade = Grade.Passed;
                }
                else
                {
                    this.grade = Grade.Failed;
                }

            }

        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("  * {0}: Points - {1}, Grade - {2}", this.Course.Name, this.CoursePoints, this.Grade));
     
            return builder.ToString();
        }


    }
}
