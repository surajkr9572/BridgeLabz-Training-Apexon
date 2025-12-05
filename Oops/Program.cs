using Oops.Constructor;
using System.Runtime.ConstrainedExecution;

namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            Person p1 = new Person("ayush",80);
            p1.print();

            Employee emp = new Employee(123,"Ayush dlla",90);
            emp.print();
        }
    }
}
