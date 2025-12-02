using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.ConditionalStatement
{
    internal class LeapYear
    {
        int year;
        public LeapYear(int year)
        {
            this.year = year;
        }
        public void LeapYearExample()
        {
            if((year%4==0  && year%100!=0) || (year % 400 == 0))
            {
                Console.WriteLine("This is Leap Year");
            }
            else
            {
                Console.WriteLine("This is not a Leap year");
            }
        }
    }
}
