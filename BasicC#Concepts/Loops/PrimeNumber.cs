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
