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
        public void ConditionalExample(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("Enter positive Number : ");
            }
            else
            {
                
                Random r = new Random();
                int tails = 0;
                int heads = 0;
                for(int i=0;i< number; i++)
                {
                    double randomValue = r.NextDouble();
                    if (randomValue < 0.5)
                    {
                        tails++;
                    }
                    else
                    {
                        heads++;
                    }

                   
                }
                int TailPercent = (tails * 100) / number;
                int HeadPercent=(heads * 100) / number;
                Console.WriteLine($"Tails: {TailPercent}");
                Console.WriteLine($"Heads: {HeadPercent}");

            }

            
        }
    }
}
