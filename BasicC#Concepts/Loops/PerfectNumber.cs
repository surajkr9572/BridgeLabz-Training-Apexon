/*Perfect Number
a. Just like the Armstrong number, the Perfect Number is also a special type of
positive number. When the number is equal to the sum of its positive divisors
excluding the number, it is called a Perfect Number. For example, 28 is the perfect
number because when we sum the divisors of 28, it will result in the same number.
The divisors of 28 are 1, 2, 4, 7, and 14. So,
b. 28 = 1+2+4+7
c. 28 = 28
*/

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
