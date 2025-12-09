using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Constructor
{
    internal class Person
    {
        public string name;
        public int age;
        //static Constructor
        static Person()
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }

        //Default Constructor
        public Person()
        {
            name = "suraj";
            age = 23;
            Console.WriteLine("Default Constructor Called..");
        }
        //Copy Constructor
        public Person(Person p)
        {
            this.name = p.name;
            this.age = p.age;
            
            Console.WriteLine($"Name of First Person is {p.name} and age is {p.age}");
        }
        //Parameterised Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void print()
        {
            Console.WriteLine($"Name of Second person {name} and age {age}");
        }
    }
}
