 /*Flip Coin and print percentage of Heads and Tails
a. I/P -> The number of times to Flip Coin. Ensure it is a positive integer.
b. Logic -> Use Random Function to get value between 0 and 1. If < 0.5 then tails or
heads
c. O/P -> Percentage of Head vs Tails
 */


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
