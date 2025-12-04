//String Compression: Implement a method to compress a string using counts of repeated characters(e.g., "aaabb" becomes "a3b2").

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class StringCompression
    {
        public string compress(string ss)
        {
            Dictionary <char,int> dict=new Dictionary<char, int> ();
            foreach(char c in ss)
            {
                if(dict.ContainsKey(c))
                {
                    dict[c] = dict[c] + 1;
                }
                else
                {
                    dict[c] = 1;
                }
            }
            string st = "";
            foreach(var e in dict)
            {
                st += e.Key;
                st += e.Value;
            }
            return st;
        }
    }
}
