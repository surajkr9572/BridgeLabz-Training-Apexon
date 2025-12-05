using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Constructor
{
    internal class Person
    {
        public string name;
        public int age;

        //Default
        public Person()
        {
            Console.WriteLine("Default Constructor Called..");
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void print()
        {
            Console.WriteLine($"Name of person {name} and age {age}");
        }
    }
}
