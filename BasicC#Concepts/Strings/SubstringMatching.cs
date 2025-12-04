using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class SubstringMatching
    {
        public int checkstring(string str, string pattern)
        {
            int n = str.Length;
            int m= pattern.Length;

            for(int i = 0; i <=n - m; i++)
            {
                int first = i, second = 0;
                while (second < m)
                {
                    if (str[first] == pattern[second])
                    {
                        second++;
                        first++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (second == m)
                {
                    return first - second;
                }
            }
            return -1;
        }
    }
}
