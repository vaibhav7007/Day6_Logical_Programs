using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalPrograms
{
    class Watch
    {
        public static void CalculateTime()
        {
            long Clicks = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Clicks = stopwatch.ElapsedTicks;
            Console.WriteLine("The elapsed time is: " + Clicks);
        }
    }
}