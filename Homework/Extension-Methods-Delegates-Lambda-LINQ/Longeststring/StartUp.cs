using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Longeststring.Extensions;

namespace Longeststring
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var text = new string[] { "Ivan", "Dragan", "Nikodim", "Stamat", "Haralampi" };

            var result=text.LongestStringInArray();
            Console.WriteLine(result);
        }
    }
}