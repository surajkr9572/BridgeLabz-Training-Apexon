using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Inheritance.SingleLevelExample
{
    internal class Employeee: Personn
    {
        public int salary;
        public Employeee()
        {
            Console.WriteLine("This is Employee Class...");
        }
        public Employeee(string name, int age,int id,int salary) : base(name, age, id)
        {
            this.salary = salary;
        }
        public void print()
        {
            Console.WriteLine($"Employee name is {name} age is {age} id is {id} and salary is {salary}");
        }
    }
}
