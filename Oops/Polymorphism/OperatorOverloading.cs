using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Polymorphism
{
    internal class OperatorOverloading
    {
        public int Hours;
        public int Minutes;
        public OperatorOverloading(int Hours,int Minutes)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
        }
        public static OperatorOverloading operator + (OperatorOverloading t1, OperatorOverloading t2)
        {
            
                int ExtraHours = (t1.Minutes + t2.Minutes) / 60;
                int totalminutes = (t1.Minutes + t2.Minutes) % 60;

            return new OperatorOverloading( t1.Hours + t2.Hours + ExtraHours, totalminutes);
        }
        public override string ToString()
        {
            return $"{Hours}h:{Minutes}m";
        }
    }
}
