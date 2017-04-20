using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longeststring.Extensions
{
    public static class Extension
    {

        public static string LongestStringInArray(this string[] array)
        {
            var result = array
                .OrderByDescending(str => str.Length)
                .First()
                .ToString();
            return result;
        }
    }
}
