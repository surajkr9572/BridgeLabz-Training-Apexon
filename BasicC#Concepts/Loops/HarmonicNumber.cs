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
