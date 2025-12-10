using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Hiding.MethodHiding
{
    internal class Mchild: Mperson
    {
        public new static void show()
        {
            Console.WriteLine("Child Class...");
        }
    }
}
