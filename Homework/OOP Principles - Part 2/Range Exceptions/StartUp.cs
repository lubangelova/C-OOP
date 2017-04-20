using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Exceptions
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 56,68,262, -53, 1000, -96 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                if (numbers[i]<0 || numbers[i]>100)
                {
                    try
                    {
                        throw new InvalidRangeException<int>("Invalid input", 0, 100);
                    }
                    catch (InvalidRangeException<int> ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine();
                }
            }

            var date = DateTime.Now;
            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);

            try
            {
                Console.WriteLine(date);
                if (date<startDate ||date> endDate)
                {
                    throw new InvalidRangeException<DateTime>("Invalid date time", startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

        }
    }
}
