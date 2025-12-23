using Delegates.PredicateImp;

namespace Delegates
{
    internal class Program
    {
        static void showmsg(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            // Action with No Parameter
            //Action greet = () => Console.WriteLine("Hello Sir");
            //greet();


            //Action With one parameter
            //Action<string> printmsg = msg => Console.WriteLine(msg);
            //printmsg("hello sir");

            //Action with two parameter
            //Action<int, int> Sum = (a, b) => Console.WriteLine($"Sum : {a+b}");
            //Sum(2, 3);

            //Action With multiple Parameter
            //Action<string> processName = name => { string upper = name.ToUpper(); Console.WriteLine(upper); };
            //processName("suraj");

            //Action with Name method
            Action<string> action = showmsg;
            action("suraj");
        }
    }
}
