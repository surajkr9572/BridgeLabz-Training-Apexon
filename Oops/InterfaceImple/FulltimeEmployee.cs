    using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.InterfaceImple
{
    internal class FulltimeEmployee : ISalary
    {
        int Monthsalary { get; set; }
        public FulltimeEmployee(int Monthsalary)
        {
            this.Monthsalary = Monthsalary;
        }
        public int calculateSalary()
        {
            return Monthsalary;
        }
    }
}
