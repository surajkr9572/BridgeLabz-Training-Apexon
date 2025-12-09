using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Inheritance.MultiLevelExample
{
    internal class MultiLevelDogs: MultiLevelExampleMammal
    {
        public MultiLevelDogs(string name) : base(name)
        {
        }
        public void Sleep()
        {
            Console.WriteLine($"{name} is Sleeping...");
        }
    }
}
