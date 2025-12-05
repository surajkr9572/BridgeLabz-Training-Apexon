using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Constructor
{
    internal class Employee : Person
    {
        public int salary;
        public Employee(int salary, string name, int age) : base(name, age)
        {
            this.salary = salary;
        }
        public virtual void print()
        {
            base.print();
            Console.WriteLine($"Salary : {salary}");
        }
    }
}
