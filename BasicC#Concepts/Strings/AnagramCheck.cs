//Check if two strings are anagrams of each other (contain the same characters in a different order).

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class AnagramCheck
    {
        public bool Anagram(string s1, string s2)
        {
            char[]ch1=s1.ToCharArray();
            char[]ch2=s2.ToCharArray();
            for(int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i]>=65 && ch1[i] <= 90)
                {
                    ch1[i] = (char)(ch1[i] + 32);
                }
            }
            for(int i = 0; i < ch2.Length; i++)
            {
                if(ch2[i]>=65 && ch2[i] <= 90)
                {
                    ch2[i] = (char)(ch2[i] + 32);
                }
            }
            Array.Sort(ch1);
            Array.Sort(ch2);
            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] != ch2[i]) return false;

            }
            return true;
        }
    }
}
