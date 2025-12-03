/*Reverse a number
In C#, we can reverse a number either by using for loop, while loop, or using recursion.
The simplest way to reverse a number is by using for loop or while loop.In order to
reverse a number, we have to follow the following steps:
a.We need to calculate the remainder of the number using the modulo
b.After that, we need to multiply the variable reverse by 10 and add the remainder into
it.
c. We then divide the number by 10 and repeat steps until the number becomes 0.
*/

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
