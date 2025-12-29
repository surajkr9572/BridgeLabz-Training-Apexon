using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design
{
    public abstract class Page
    {
        public override string ToString()=>GetType().Name;
    }
}
