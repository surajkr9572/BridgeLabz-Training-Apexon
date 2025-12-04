//Find the First Non-Repeating Character: Given a string, find the first character that is not repeated anywhere in the string.

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class FirstNon_RepeatingCharacter
    {
        public char nonrepeating(string s)
        {
            char[]ch=s.ToCharArray();
            foreach (char c in ch)
            {
                if(Array.IndexOf(ch,c)== Array.LastIndexOf(ch,c))
                {
                    return c;
                }
            }
            return '\0';
        }
    }
}
