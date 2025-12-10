using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Abstraction
{
    abstract class Animal
    {
        public abstract void sound();
        
        public void Eat()
        {
            Console.WriteLine("Animal is eating....");
        }
    }
}
