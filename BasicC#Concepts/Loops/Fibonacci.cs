

/*Fibonacci Series
Fibonacci series is a special type of series in which the next term is the sum of the
previous two terms. For example, if 0 and 1 are the two previous terms in a series, then
the next term will be 1(0+1).*/

using BasicC_Consepts.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class Fibonacci
    {
        public void  fibonacci(int num)
        {
            int prev = 0;
            int curr = 1;
            if (num >1)
            {
                Console.WriteLine(prev);
            }
            if(num >= 2)
            {
                Console.WriteLine(curr);
            }
           
            for(int i = 3; i <= num; i++)
            {
                int next = prev + curr;
                Console.WriteLine(next);
                prev = curr;
                curr=next;
                
            }
        }
    }
}
