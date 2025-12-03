 //C# Program to Find the Largest Among Three Numbers            

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class Largest
    {
        public  void largestt(int num1,int num2,int num3)
        {
            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is Largest number");
            }
            else if(num2>num1 && num2> num3)
            {
                Console.WriteLine($"{num2} is Largest number");
            }
            else
            {
                Console.WriteLine($"{num3} is Largest number");
            }
        }
    }
}
