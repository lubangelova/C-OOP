using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;
        private IList<string> technologies=new List<string> ();
        // TODO Extract validation

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.technologies=technologies.Split(',').ToList();
        }
        public IList<string> Technologies
        {
            get
            {
                return this.technologies;
            }

            set
            {
                this.technologies = value;
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
                if (value.Length<3 || value.Length>16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
                this.username = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Trainer:")
                .AppendLine(string.Format(" - Username: {0}", this.Username))
                .Append(" - Technologies:")
                .Append(PrintTechnologies());

            return builder.ToString().TrimEnd();
        }

        private string PrintTechnologies()
        {
            var builder = new StringBuilder();

            foreach (var technology in technologies)
            {
                builder.Append(string.Format(" {0};", technology));
            }
            return builder.ToString().TrimEnd(';');
           
        }
    }
}

/*
* Trainer:
 - Username: <username>
 - Technologies: <technology>; <technology>; <technology>;
*/