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

            int start = 0;
           
            int mxlength = 0;
            HashSet<char> hs = new HashSet<char>();
            for(int end = 0; end < s.Length; end++)
            {
                while (hs.Contains(s[end]))
                {
                    hs.Remove(s[start]);
                    start++;
                }
                hs.Add(s[end]);
                mxlength=Math.Max(mxlength, end- start+1);

            }
            return mxlength;
            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //int left = 0;
            //int right = 0;
            //int len = 0;
            //while (right < s.Length)
            //{
            //    if (dict.ContainsKey(s[right]))
            //    {
            //        left=Math.Max(left, dict[s[right]]+1);
            //    }
            //    dict[s[right]]= right;
            //    len = Math.Max(len, right - left + 1);
            //    right++;
            //}
            //return len;
        }
    }
}
