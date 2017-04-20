using Academy.Core.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils
{
    public class VideoResource : LectureResouce
    {
        public VideoResource(string type, string name, string url, DateTime uploadedOn) 
            : base(type, name, url)
        {
            this.UploadedOn = uploadedOn; 
        }

        protected DateTime UploadedOn { get; set; }

        protected override string PrintAditionalInfo()
        {
            var buider = new StringBuilder();
            buider.AppendLine("     - Type: Video")
            .Append(string.Format("     - Uploaded on: {0}", this.UploadedOn));
            return buider.ToString();
        }
    }
}
