using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.ShawdowCopy
{
    internal class PersonForShallow
    {
        public string Name;
        public CityForShallow adre;
        public PersonForShallow ShallowCopy()
        {
            return (PersonForShallow)this.MemberwiseClone();
        }
    }
}
