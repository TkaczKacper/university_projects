using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    class Counter
    {
        public int count;
        private Timer timer = new Timer();

        public Counter(int initialTime)
        {
            count = initialTime;
        }
        public void Start()
        {
            Stop();
            timer.Interval = 1000;
            timer.Elapsed += (sender, e) =>
            {
                Console.SetCursorPosition(30, 2);
                Console.WriteLine("{0,2}", count--);
                Console.SetCursorPosition(20, 14);
                if (count < 0) 
                { 
                    timer.Stop();
                }
            };
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
    }
}
