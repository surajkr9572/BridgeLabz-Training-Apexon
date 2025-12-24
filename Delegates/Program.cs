using Delegates.PredicateImp;
using Delegates.Events;
using System.Diagnostics;
using System.Reflection;

namespace Delegates
{
    internal class Program
    {
        //static bool CheckPositive(int number)
        //{
        //    return number > 0;
        //}


        //static int add(int a,int b)
        //{
        //    return a + b; 
        //}
        //static int sub(int a,int b) { return a - b; }
        //static int mult(int a,int b) { return a * b; }
        //static int div(int a,int b)
        //{ return a / b; }
        //static void showmsg(string msg)
        //{
        //    Console.WriteLine(msg);
        //}
        //public delegate int Delegate(int a, int b, int c,int d);
        //public static int sum(int a,int b,int c,int d)
        //{
        //    return a + b + c + d; 
        //}
        static void Main(string[] args)
        {
            //------------------------------------------------------------Predicate---------------------------------------------------------
            //    Predicate<int> isEven = n => n % 2 == 0;
            //Console.WriteLine(isEven(10));
            //Console.WriteLine(isEven(7));



                //Predicate<int> isPositive = CheckPositive;

                //Console.WriteLine(isPositive(5));
                //Console.WriteLine(isPositive(-3));
       

        //----------------------------------------------------------------Action---------------------------------------------------------
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
        //Action<string> action = showmsg;
        //action("suraj");


        //------------------------------------------------------custome Delegate---------------------------------------------------
        //Delegate o = sum;
        //Console.WriteLine(o(1, 2, 3,4));
        //---------------------------------------------------------Func-----------------------------------------------------------

        //Func with One Parameter
        //Func<int, int> square = a => a * a;
        //Console.WriteLine(square(9));

        //Func with Two Parameter
        //Func<int, int, int> Sum = (a, b) => a + b;
        //Console.WriteLine(Sum(4,8));

        //Func with Three Parameter
        //Func<int, int, int, int> sum=(a, b, c) => a + b + c;
        //Console.WriteLine(sum(4,8,12));

        //Func With No Parameter
        //Func<string> fun = () => ("Hello Sir");
        //Console.WriteLine(fun());


        //Func with Statement Block
        //Func<int, int, int> mult = (a, b) =>
        //{
        //    int ans = a * b;
        //    return ans;
        //};
        //Console.WriteLine(mult(2,9));

        //Func with method
        //Func<int, int, int> fun = add;

        //Console.WriteLine(fun(8,7));
        //fun = sub;
        //Console.WriteLine(fun(8,7));
        //fun= mult;
        //Console.WriteLine(fun(8,7));
        //fun= div;
        //Console.WriteLine(fun(14,7));

        //----------------------------------------------------------Event------------------------------------------------------------
        //CreateCustomeHandle customehandle = new CreateCustomeHandle();
        //// Subscribing to the event
        //customehandle.ProcessCompleted += ProcessCompletedHandler;

        //process.Start();

        //BuiltInEventHandler eventt = new BuiltInEventHandler();
        //eventt.TaskCompleted += manage_TaskCompleted;
        //eventt.Runtask();


        // ------------------------------------------------------Reflaction---------------------------------------------------------
        //Type t = typeof(string);
        //    Console.WriteLine($"Name : {t.Name}");
        //    Console.WriteLine($"Full Name : {t.FullName}");
        //    Console.WriteLine($"Namespace : {t.Namespace}");
        //    Console.WriteLine($"Base Type : {t.BaseType}");







    }
       //static void manage_TaskCompleted(object sender, EventArgs e)
       // {
       //     Console.WriteLine("Task Completed Event Fired!");
       // }

        //static void ProcessCompletedHandler()
        //{
        //    Console.WriteLine("Process Completed!");
        //}
    }
}
