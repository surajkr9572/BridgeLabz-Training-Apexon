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
