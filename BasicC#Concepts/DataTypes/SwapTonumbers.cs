 //C# Program to Swap Two Numbers


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.DataTypes
{
    internal class SwapTonumbers
    {
        public SwapTonumbers()
        {
            Console.WriteLine("Two numbers are : ");
        }
        public void Swap(int num1, int num2)
        {
            int temp=num1;
            num1=num2;
            num2=temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
