using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Polymorphism.runTimePolymorphism
{
    internal class runtimefile1
    {
        public runtimefile1()
        {
            Console.WriteLine("runtime Polymorphism...");

        }
        public virtual void write()
        {
            Console.WriteLine("Write in file 1");
        }
    }
}
