using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>(5);
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(5);
            list.Add(2);
            list.Add(-1);

            Console.WriteLine(list.IndexOf(1));
            list.Remove(2);
            
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Count);

            list.Insert(3, -6);
            Console.WriteLine(list.ToString());

        }
    }
}
