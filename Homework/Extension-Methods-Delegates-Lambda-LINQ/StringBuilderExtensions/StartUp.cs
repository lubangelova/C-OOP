using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder("This is test for Substring method");
            var result = text.Substring(5, 7);
            Console.WriteLine(result);


            var list = new int[] { 1, 3, 5, 8, 7, 9, 10 };
            Console.WriteLine(list.SumOfCollection());
            Console.WriteLine(list.ProductOfCollestion());
            Console.WriteLine(list.AverageOfCollection());
            Console.WriteLine(list.MinOfCollection());
            Console.WriteLine(list.MaxOfCollection());

        }
    }
}
