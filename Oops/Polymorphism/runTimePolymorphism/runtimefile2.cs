using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Polymorphism.runTimePolymorphism
{
    internal class runtimefile2: runtimefile1
    {
        public override void write()
        {
            Console.WriteLine("Write in file2...");
        }
    }
}
