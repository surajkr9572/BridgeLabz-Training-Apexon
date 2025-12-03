/*Power of 2
a. Desc -> This program takes a command-line argument N and prints a table of the
powers of 2 that are less than or equal to 2^N.
b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
c. Logic -> repeat until i equals N.
d. O/P -> Print the year is a Leap Year or not.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class PowerMethodUse
    {
        public PowerMethodUse()
        {
            Console.WriteLine("Power method use here : ");
        }
        public void PowerMethod(int data)
        {
            if (data > 31)
            {
                Console.WriteLine("data overflow an int");
            }
            else
            {
               
                for(int i = 1; i <data; i++)
                {
                    int tabel=Convert.ToInt32(Math.Pow(2, i));
                    Console.WriteLine($"2 ^ {i} = {tabel}" );
                }
            }
        }
    }
}
