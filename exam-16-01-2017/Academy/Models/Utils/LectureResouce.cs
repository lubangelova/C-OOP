using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    public class LectureResouce : ILectureResouce
    {
        private string name;
        private string url;

        public LectureResouce(string type, string name, string url)
        {
            this.Type = type;
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Resource name should be between 3 and 15 symbols long!");
                }
                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5 || value.Length > 150)
                {
                    throw new ArgumentException("Resource url should be between 5 and 150 symbols long!");
                }
                this.url = value;
            }
        }

        private string Type
        {
            get;
            set;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("    * Resource:")
                .AppendLine(string.Format("     - Name: {0}", this.Name))
                .AppendLine(string.Format("     - Url: {0}", this.Url));
           
            builder.AppendLine(PrintAditionalInfo());
            return builder.ToString();
        }

        protected virtual string PrintAditionalInfo()
        {
            return "";
        }
    }
}
