/*Prime Number
Just like the Perfect number, the Prime number is also a special type of number. When
the number is divided greater than 1 and divided by 1 or itself is referred to as the Prime
number. 0 and 1 are not counted as prime numbers. All the even numbers can be
divided by 2, so 2 is the only even prime minister.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class PrimeNumber
    {
        public bool prime(int num)
        {
            if(num <=1) return false;
            if(num==2) return true;
            for(int i = 3; i < num; i++)
            {
                if(num%i==0) return false;
            }
            return true;
        }
    }
}
