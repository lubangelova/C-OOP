using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public delegate void TimerMethod();
    public class Timer
    {
        public Timer (int seconds,TimerMethod method)
        {
            this.Seconds = seconds;
            this.Method = method;
        }

        public TimerMethod Method { get; private set; }
        public int Seconds { get; private set; }

        public void Run()
        {
            Console.WriteLine($"Run at {this.Seconds} seconds!");
            this.Method();
        }
    }
}
