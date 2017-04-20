using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class StringBuilderextensions
    {

        public static StringBuilder Substring(this StringBuilder text,int index, int length)
        {
            var result = new StringBuilder();
            if (index < 0)
            {
                index = 0;
            }
            else if (length>text.Length || length+index>text.Length)
            {
                length = text.Length - index;
            }
           return result.Append(text.ToString(index, length));
            
        }
    }
}
