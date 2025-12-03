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
