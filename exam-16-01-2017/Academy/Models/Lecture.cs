using System;
using System.Collections.Generic;
using Academy.Models.Contracts;
using System.Text;

namespace Academy.Models
{
    internal class Lecture : ILecture
    {
        private DateTime date;
        private string name;
        private IList<ILectureResouce> resouces;


        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date =DateTime.Parse(date);
            this.Trainer = trainer;
            this.resouces = new List<ILectureResouce>();
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
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
               if (value.Length<5 || value.Length>30)
                {
                    throw new ArgumentException("Lecture's name should be between 5 and 30 symbols long!");
                }
                this.name = value;
            }
        }

        public IList<ILectureResouce> Resouces
        {
            get
            {
                return this.resouces;
            }
        }

        public ITrainer Trainer
        {
            get;

            set;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("  * Lecture:")
                .AppendLine(string.Format("   - Name: {0}", this.Name))
                .AppendLine(string.Format("   - Date: {0}", this.Date))
                .AppendLine(string.Format("   - Trainer username: {0}", this.Trainer.Username))
                .AppendLine("   - Resources:");
            if (this.resouces.Count == 0)
            { 
                builder.Append("    * There are no resources in this lecture.");
            }
            else
            {
                builder.Append(PrintResorces());
            }
          
            return builder.ToString();
        }
        private string PrintResorces()
        {
            var buider = new StringBuilder();
            foreach (var resource in resouces)
            {
                buider.AppendLine(resource.ToString());
            }
            return buider.ToString().TrimEnd();
        }
    }
}
/*
  * Lecture: 
   - Name: <name>
   - Date: <date>
   - Trainer username: <username>
   - Resources:
    * There are no resources in this lecture.
*/