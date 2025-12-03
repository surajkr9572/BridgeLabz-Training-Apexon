using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class TicketPrice
    {
        public void ticketPrice(int age)
        {
            int price = 0;
            Console.WriteLine("Is it Matinee Show ? (yes/no)");
            String show=Console.ReadLine().ToLower();
            if (age < 12)
            {
                price = 100;
            }
            else if(age>=12 && age<=64)
            {
                price = 250;
            }
            else
            {
                price = 150;
            }
            if (show == "yes")
            {
                Console.WriteLine($"Ticket Price : {price - 50}");
            }
            else
            {
                Console.WriteLine($"Ticket Price : , {price}");
            }
        }
    }
}
