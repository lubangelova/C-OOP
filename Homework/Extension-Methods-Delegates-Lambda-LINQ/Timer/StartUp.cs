using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class StartUp
    {
        static void Main(string[] args)

        {
            TimerMethod testMethod = Method1;
            testMethod += Method2;
            var timer = new Timer(25, testMethod);
            timer.Run();
        }



        public static void Method1()
        {
            Console.WriteLine($"This is method 1 at DateTime :{DateTime.Now.Second}");
        }

        public static void Method2()
        {
            Console.WriteLine($"This is method 2 after 2 seconds: {DateTime.Now.Second+2}");
        }
    }
}
