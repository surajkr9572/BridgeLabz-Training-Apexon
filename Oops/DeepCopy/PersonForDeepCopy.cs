using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Oops.DeepCopy
{
    internal class PersonForDeepCopy
    {
        public string Name;
        public AddressForDeepCopy addr;
        public PersonForDeepCopy Deepcopy()
        {
            PersonForDeepCopy copy = new PersonForDeepCopy();
            copy.Name = this.Name;
            copy.addr = new AddressForDeepCopy();
            copy.addr.city = this.addr.city;

            return copy;
        }
    }
}
