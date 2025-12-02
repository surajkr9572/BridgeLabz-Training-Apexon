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
