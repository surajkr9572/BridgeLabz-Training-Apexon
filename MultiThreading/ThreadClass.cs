using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadClass
    {
        public static void method1()
        {
            for(int i = 0; i <=5; i++)
            {
                Console.WriteLine("Method 1 : "+i);
            }
        }
    }
}
