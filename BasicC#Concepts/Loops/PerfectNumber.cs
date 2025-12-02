using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class PerfectNumber
    {
        public bool perfect(int num)
        {
            int sum = 1;
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    sum += i + (num / i);
                }
            }
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }
    }
}
