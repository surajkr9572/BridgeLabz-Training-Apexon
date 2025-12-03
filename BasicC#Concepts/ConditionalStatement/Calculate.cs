//Implement a menu-driven calculator in C# that allows users to perform basic operations (addition, subtraction, multiplication, division).
//Use conditional statements to execute the selected operation and handle invalid inputs.


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class Calculate
    {
        public void calculater(int value1,int value2)
        {
            int result = 0;
            Console.WriteLine("------ MENU DRIVEN CALCULATOR ------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            if(choice == 5)
            {
                Console.WriteLine("Exiting Calculater");
                return;
            }
            switch (choice)
            {
                case 1:
                    result = value1 + value2;
                    Console.WriteLine("result: " + result);
                    break;
                case 2:
                    result = value1 - value2;
                    Console.WriteLine("result: " + result);
                    break;
                case 3:
                    result = value1 * value2;
                    Console.WriteLine("result: " + result);
                    break;
                case 4:
                    if (value2 == 0)
                    {
                        Console.WriteLine("Error can not divide by Zero");
                        break;
                    }
                    else
                    {
                        result = value1 / value2;
                        Console.WriteLine("result: " + result);
                        break ;
                    }   
                default:
                    Console.WriteLine("Invalid number choose between 1-5");
                    break;
            }
        }

    }
}
