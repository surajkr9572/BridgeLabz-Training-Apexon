using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.DataTypes
{
    internal class Quotient_Remainder
    {
        public Quotient_Remainder()
        {
            Console.WriteLine("Quotient and Remainder Ans: ");
        }
        public void Quotient(int Dividend, int Divisor)
        {
            int quotient = Dividend / Divisor;
            int reminder = Dividend % Divisor;
            Console.WriteLine($"Quotient : {quotient}");
            Console.WriteLine($"reminder : {reminder}");
        }
    }
}
