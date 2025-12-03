/*Coupon Numbers
a. Desc -> Given N distinct Coupon Numbers, how many random numbers do you
need to generate a distinct coupon number? This program simulates this random
process.
b. I/P -> N Distinct Coupon Number
c. Logic -> repeatedly choose a random number and check whether it's a new one.
d. O/P -> total random number needed to have all distinct numbers.
e. Functions => Write Class Static Functions to generate random numbers and to
process distinct coupons.
*/

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class CouponNumbers
    {
        public int Countrandom(int n) 
        {
            int cnt = 0;
            HashSet<int> hs=new HashSet<int>();
            Random r=new Random();
            while (hs.Count < n)
            {
                cnt++;
                int num= r.Next(n);
                hs.Add(num);
            }
            return cnt;
        }
    }
}
