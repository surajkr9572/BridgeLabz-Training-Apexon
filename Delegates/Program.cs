using Delegates.PredicateImp;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PredicateWithLambda pwl = new PredicateWithLambda();
            Console.WriteLine( pwl.Even(5));
            Console.WriteLine(pwl.Even(6));
        }
    }
}
