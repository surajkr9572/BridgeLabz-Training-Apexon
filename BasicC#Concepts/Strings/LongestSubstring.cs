//.Longest Substring Without Repeating Characters: Find the length of the longest substring in a given string without repeating characters.

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class LongestSubstring
    {
        public int length(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int left = 0;
            int right = 0;
            int len = 0;
            while (right < s.Length)
            {
                if (dict.ContainsKey(s[right]))
                {
                    left=Math.Max(left, dict[s[right]]+1);
                }
                dict[s[right]]= right;
                len = Math.Max(len, right - left + 1);
                right++;
            }
            return len;
        }
    }
}
