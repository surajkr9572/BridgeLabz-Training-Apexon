/*Harmonic Number
a. Desc -> Prints the Nth harmonic number: 1 / 1 + 1 / 2 + ... +1 / N
b.I / P->The Harmonic Value N.Ensure N != 0
c.Logic->compute 1 / 1 + 1 / 2 + 1 / 3 + ... +1 / N
d.O / P->Print the Nth Harmonic Value.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class HarmonicNumber
    {
        public HarmonicNumber()
        {
            Console.WriteLine("Harmonic Number Print: ");
        }
        public void Harmonic(int num)
        {
            double sum = 0;
            for(int i = 1; i<= num; i++)
            {

                sum += (double)1 / i;
                
            }
            Console.WriteLine(sum);
        }
    }
}
