using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.PredicateImp
{
     class PredicateWithLambda
    {
        public bool Even(int num)
        {
            Predicate<int> pr = n => n % 2 == 0;
            return pr(num);
        }
    }
}
