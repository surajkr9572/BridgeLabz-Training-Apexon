using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Inheritance.MultiLevelExample
{
    internal class MultiLevelAnimal
    {

        //set the 
        public string name;
        public MultiLevelAnimal(string name)
        {
            this.name = name;
        }
       public void Eat()
        {
            Console.WriteLine($"{name} is eating..");
        }
    }
}
