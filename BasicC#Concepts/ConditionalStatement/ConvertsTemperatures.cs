using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class ConvertsTemperatures
    {
        public void temperatureConvert(int temperature)
        {
            Console.WriteLine("Press 1 for Celsius to Fahrenheit");
            Console.WriteLine("Press 2 for Fahrenheit to Celsius");

            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                double Fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine(Fahrenheit);
            }
            else
            {
                double Celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine(Celsius);
            }
        }
    }
}
