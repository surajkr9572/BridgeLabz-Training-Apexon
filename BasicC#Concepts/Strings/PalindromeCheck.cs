//Palindrome Check: Determine if a given string is a palindrome (reads the same forwards and backwards).

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class PalindromeCheck
    {
        public bool checkPalindrom(string str)
        {
            char[] chars = str.ToCharArray();
            for(int i=0;i<chars.Length; i++)
            {
                if (chars[i]>=65 && chars[i] <= 90)
                {
                    chars[i] = (char)(chars[i] + 32);
                }
            }
            string s=new string(chars);
            int n = s.Length;
            for (int i=0;i< n / 2; i++)
            {
                if (s[i]!= s[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
