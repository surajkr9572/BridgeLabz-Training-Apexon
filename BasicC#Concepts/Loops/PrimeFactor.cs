using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class PrimeFactor
    {
        public PrimeFactor()
        {
            Console.WriteLine("Prime Factor Are: ");
        }
        public void primefact(int val)
        {
            int temp = val;
            while (temp % 2 == 0)
            {
                Console.WriteLine(2);
                temp /= 2;
            }
            for(int i = 3; i * i < val; i+=2)
            {
                while (temp % i == 0)
                {
                    Console.WriteLine(i);
                    temp /= i;
                }
            }
            if (temp > 1)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
