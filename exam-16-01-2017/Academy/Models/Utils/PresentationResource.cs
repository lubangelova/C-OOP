using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    public class PresentationResource : LectureResouce
    {
        public PresentationResource(string type, string name, string url) 
            : base(type, name, url)
        {
        }

        protected override string PrintAditionalInfo()
        {
            return "     - Type: Presentation";
        }
    }
}
