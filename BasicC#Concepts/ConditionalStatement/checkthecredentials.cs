//Design a simple login system in C# where users provide their username and password.
//Use conditional statements to check the credentials and provide appropriate feedback, such as successful login, incorrect username, incorrect password, or account locked.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class checkthecredentials
    {
        public void check()
        {
            int cnt = 0;
            string name = "suraj";
            string password = "Suraj@123";
            while (cnt < 3)
            {
                Console.WriteLine("Enter Username");
                string username=Console.ReadLine(); 
                Console.WriteLine("Enter Password");
                string userpassword=Console.ReadLine();

                if (username == name && userpassword == password)
                {
                    Console.WriteLine("Successful Login");
                    return;
                }
                else
                {
                    if (username == name && userpassword != password)
                    {
                        Console.WriteLine("incorrect password");
                        cnt++;
                        Console.WriteLine($"You have only {3 - cnt} attamped left");
                    }
                    else if (username != name && userpassword == password)
                    {
                        Console.WriteLine("incorrect username");
                        cnt++;
                        Console.WriteLine($"You have only {3 - cnt} attamped left");
                    }
                    else
                    {
                        Console.WriteLine("incorrect Username and Password");
                        cnt++;
                        Console.WriteLine($"You have only {3 - cnt} attamped left");
                    }
                }
            }
            Console.WriteLine("Account Blocked");
        }
    }
}
