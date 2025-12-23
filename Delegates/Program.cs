using Delegates.PredicateImp;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PredicateWithLambda pwl = new PredicateWithLambda();
            //Console.WriteLine( pwl.Even(5));
            //Console.WriteLine(pwl.Even(6));


            //Predicate<int> pos = PredicateWithName.check;
            //Console.WriteLine(pos(-2));
            //Console.WriteLine(pos(4));

            List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6 };
            PredicateWithCollections ps=new PredicateWithCollections();
            var ans = ls.Find(ps.Even);
            var ans1=ls.FindAll(ps.Even);
            Console.WriteLine(ans);
            foreach(int i in ans1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
