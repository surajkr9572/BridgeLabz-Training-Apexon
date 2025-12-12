namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number ...");
            
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            Try_Catch tc=new Try_Catch(a,b);
            tc.fun();
            
        }
    }
}
