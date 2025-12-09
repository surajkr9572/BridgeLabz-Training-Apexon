using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Inheritance.MultiLevelExample
{
    internal class MultiLevelExampleMammal : MultiLevelAnimal
    {
        public MultiLevelExampleMammal(string name) : base(name)
        {
        }
        public void Walk()
        {
            Console.WriteLine($"{name} is Walking...");
        }
    }
}
