//Count Vowels and Consonants: Write a function to count the number of vowels and consonants in a given string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Strings
{
    internal class CountVowels_Consonants
    {
        public void count(string s)
        {
            string vowels = "aeiouAEIOU";
            int V_cnt = 0;
            int C_cnt = 0;
            foreach(char c in s)
            {
                if (vowels.Contains(c))
                {
                    V_cnt++;
                }
                else
                {
                    C_cnt++;
                }
            }
            Console.WriteLine("Total vowels are : " + V_cnt);
            Console.WriteLine("Total consonants are : " + C_cnt);
        }
    }
}
