using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class ReverseNumber
    {
        public int reverse(int number)
        {
            int rev = 0;
            while (number != 0)
            {
                int rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            return rev;
        }
    }
}
