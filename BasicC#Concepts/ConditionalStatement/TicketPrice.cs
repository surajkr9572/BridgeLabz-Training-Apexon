//Write a C# program that calculates the price of a movie ticket based on the age of the customer and the time of the movie.
//Implement different pricing rules for children (under 12), adults (12-64), and seniors (65+), and consider matinee discounts.



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
