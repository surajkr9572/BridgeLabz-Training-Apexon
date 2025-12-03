//Design a C# program that calculates the fine for overdue library books.
//The program should take the number of days a book is overdue as input and apply different fine rates
//based on predefined rules (e.g., first 7 days free, after that $0.50 per day).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class LibraryBooks
    {
        public void library(int days)
        {
            double fine = 1;
            if (days > 7)
            {
                fine = days * 0.5;
            }
            Console.WriteLine(fine+"$");
        }
    }
}
