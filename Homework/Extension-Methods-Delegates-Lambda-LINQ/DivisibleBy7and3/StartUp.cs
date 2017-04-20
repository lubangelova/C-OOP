using System;

using DivisibleBy7and3.Extensions;

namespace DivisibleBy7and3
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var list = new int[] { 2, 5, 7, 21, 28, 42, 9, 64, 45, 68, 10 };
            var result=list.DivisibleBy7and3();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
