using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    public class HomeworkResource : LectureResouce
    {
        public HomeworkResource(string type, string name, string url, DateTime duedate) 
            : base(type, name, url)
        {
            this.DueDate = duedate;
        }

        private DateTime DueDate { get; set; }

        protected override string PrintAditionalInfo()
        {
            var buider = new StringBuilder();
            buider.AppendLine("     - Type: Homework")
            .Append(string.Format("     - Due date: {0}",this.DueDate));
            return buider.ToString();
        }
    }

   
}
