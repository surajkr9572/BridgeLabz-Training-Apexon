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
            int cnt = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Stopwatch  Started: ");
            for (int i = 0; i < 1000; i++)
            {
                cnt++;
            }
            stopwatch.Stop();
            Console.WriteLine("Stopwatch Closed: ");
            TimeSpan ts=stopwatch.Elapsed;

            Console.WriteLine($"{ts.Hours} Hours {ts.Minutes} Minutes {ts.Seconds} Second {ts.Milliseconds} Millisecond");
        }
    }
}
