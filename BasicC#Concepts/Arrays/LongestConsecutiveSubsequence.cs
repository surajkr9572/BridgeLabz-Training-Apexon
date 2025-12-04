using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Arrays
{
    internal class LongestConsecutiveSubsequence
    {
        public int subsequence(int[] a)
        {
            Array.Sort(a);
            int cnt = 0;
            int length = 1;
            int prevValue = -1;
            for(int i=0;i<a.Length; i++)
            {
                if (a[i]- 1 == prevValue)
                {
                    cnt++;
                    prevValue=a[i];
                }
                else if (a[i]!=prevValue)
                {
                    prevValue = a[i];
                    cnt = 1;
                }
                length=Math.Max(cnt, length);
            }
            return length;
        }
    }
}
