using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Concepts.ConditionalStatement
{
    internal class CoinsProblem
    {
        public CoinsProblem()
        {
            Console.WriteLine("Conditional Statements");
        }
        public void ConditionalExample()
        {
            Random rnd=new Random();
            double d=rnd.NextDouble();
            if (d < 0.5)
            {
                Console.WriteLine("tails");
            }
            else
            {
                Console.WriteLine("heads");
            }
        }
    }
}
