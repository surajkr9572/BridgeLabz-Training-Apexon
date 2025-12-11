using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InterfaceImple
{
    internal class PartTimeSalary : ISalary
    {
        int Hourlyrate {  get; set; }
        int HourWorks { get; set; }

        public PartTimeSalary(int hourlyrate, int hourWorks)
        {
            this.Hourlyrate = hourlyrate;
            this.HourWorks = hourWorks;
        }
        public int calculateSalary()
        {
            return Hourlyrate * HourWorks;
        }
    }
}
