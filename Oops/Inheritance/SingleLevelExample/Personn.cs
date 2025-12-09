using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Inheritance.SingleLevelExample
{
    internal class Personn
    {
        public string name;
        public int age;
        public int id;
        public Personn()
        {
            Console.WriteLine("This is Person Class...");
        }
        public Personn(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
        public void print()
        {
            Console.WriteLine($"My name is {name} my age is {age} and my id is {id}");
        }
    }
}
