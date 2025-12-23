using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.PredicateImp
{
    public class PredicateWithCollections
    {
        public bool Even(int num)
        {
            Predicate<int> p = n => n % 2 == 0;
            return p(num);
        }
    }
}
