using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class TrafficLight
    {
        public void light()
        {
            int time = 0;
            int rcnt = 5;
            int gcount = 5;
            int ycnt = 2;
            while (true)
            {
                time++;
                if (time <= 5)
                {
                    
                    Console.WriteLine($"Red - Stop {rcnt=rcnt - 1}");
                    
                }
                else if (time <= 10)
                {

                    Console.WriteLine($"Green - Go {gcount=gcount-1}");
                }
                else if (time <= 12)
                {
                    Console.WriteLine($"Yellow - ready {ycnt=ycnt-1}");
                }
                else
                {
                    time = 0;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
