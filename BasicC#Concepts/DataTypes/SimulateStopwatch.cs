/*Simulate Stopwatch Program
a. Desc -> Write a Stopwatch Program for measuring the time that elapses between
the start and end clicks
b. I/P -> Start the Stopwatch and End the Stopwatch
c. Logic -> Measure the elapsed time between start and end
d. O/P -> Print the elapsed time.*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.DataTypes
{
    internal class SimulateStopwatch
    {
        public void simulateTime()
        {
            //int cnt = 0;
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //Console.WriteLine("Stopwatch  Started: ");
            //for (int i = 0; i < 1000; i++)
            //{
            //    cnt++;
            //}
            //stopwatch.Stop();
            //Console.WriteLine("Stopwatch Closed: ");
            //TimeSpan ts=stopwatch.Elapsed;

            int timer = 0;
            Console.WriteLine("Press Enter to Start..");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { };

            DateTime start= DateTime.Now;
            Console.WriteLine("Timer Started Press Enter to Stop");
            while(Console.ReadKey(true).Key != ConsoleKey.Enter){ };

            DateTime end= DateTime.Now;

            TimeSpan ts = end - start;
            

            Console.WriteLine($"{ts.Hours} Hours {ts.Minutes} Minutes {ts.Seconds} Second {ts.Milliseconds} Millisecond");
        }
    }
}
