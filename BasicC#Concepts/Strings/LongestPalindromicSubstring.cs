//Longest Palindromic Substring: Find the longest substring in a given string that is a palindrome.


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class LongestPalindromicSubstring
    {
        public bool palindrom(string str,int start,int end)
        {
            while (start < end)
            {
                if (str[start]== str[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public string LPS(string s)
        {
            int start = 0;
            int maxLen = -1;
            int n = s.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if (palindrom(s, i, j)){
                        if (j - i + 1 > maxLen)
                        {
                            start = i;
                            maxLen = j - i + 1;
                        }
                    }
                }
            }
            return s.Substring(start, maxLen);
        }
    }
}
