using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class GradeProblem
    {
        public void Grade(int val)
        {
            if (val >= 90 && val <= 100) Console.WriteLine("A");
            else if (val >= 80 && val <= 89) Console.WriteLine("B");
            else if (val >= 70 && val <= 79) Console.WriteLine("C");
            else if (val >= 60 && val <= 69) Console.WriteLine("D");
            else Console.WriteLine("F");
        }
    }
}
