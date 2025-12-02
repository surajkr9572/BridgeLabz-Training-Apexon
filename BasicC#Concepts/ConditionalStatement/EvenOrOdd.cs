using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class EvenOrOdd
    {
        public EvenOrOdd()
        {
            Console.WriteLine("Even or odd number : ");
        }
        public void evenorodd(int value)
        {
            if(value % 2 == 0)
            {
                Console.WriteLine($"{value} is even number");
            }
            else
            {
                Console.WriteLine($"{value} is odd number");
            }
        }
    }
}
