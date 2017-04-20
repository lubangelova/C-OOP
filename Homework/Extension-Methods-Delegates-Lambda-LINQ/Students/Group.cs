using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Group
    {
        public Group(int groupNumber,string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public string DepartmentName { get; private set; }
        public int GroupNumber { get; private set; }

        public override string ToString()
        {
            return $"{this.DepartmentName}, group {this.GroupNumber}";
        }
    }
}
