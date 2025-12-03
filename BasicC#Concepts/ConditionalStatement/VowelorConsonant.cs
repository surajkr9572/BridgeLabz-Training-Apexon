 //C# Program to Check Whether an Alphabet is Vowel or Consonant


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class VowelorConsonant
    {
        public bool functionAlphabet(Char alphabet)
        {
            if(alphabet=='a' || alphabet=='e' || alphabet=='i' || alphabet=='o' || alphabet == 'u' || alphabet=='A'|| alphabet=='E' || alphabet=='I' || alphabet=='O' || alphabet=='U')
            {
                return true;
            }
            return false;
        }
    }
}
