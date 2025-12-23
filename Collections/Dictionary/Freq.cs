using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Dictionary
{
    internal class Freq
    {
        public void frequency(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (dict.ContainsKey(ch[i]))
                {
                    dict[ch[i]]++;
                }
                else
                {
                    dict[ch[i]] = 1;
                }
            }
            foreach (var e in dict)
            {
                
               Console.WriteLine(e.Key + " -->" + e.Value);

                
            }

        }
    }
}
