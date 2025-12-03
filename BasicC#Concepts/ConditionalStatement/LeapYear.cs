/*Leap Year
a. I/P -> Year, ensure it is a 4 digit number.
b. Logic -> Determine if it is a Leap Year.
c. O/P -> Print the year is a Leap Year or not.
*/

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
