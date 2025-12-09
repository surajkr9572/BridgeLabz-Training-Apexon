using Oops.Constructor;
using Oops.Static_NonStatic;
using Oops.Inheritance.SingleLevelExample;
using Oops.Inheritance.MultiLevelExample;

using System.Runtime.ConstrainedExecution;

namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p=new Person();
            //Person p2=new Person(p);
            //Person p1 = new Person("ayush",80);
            //p1.print();

            //Employee emp = new Employee(123,"Ayush dlla",90);
            //emp.print();

            //Staticc.cnt = 100;
            //Staticc.print();

            //NonStatic ns=new NonStatic();
            //ns.cnt = 100;
            //ns.print();

            //Personn p=new Personn("Suraj",23,01);
            //p.print();

            //Employeee emp = new Employeee("Suraj", 23, 01, 2340);
            //emp.print();

            MultiLevelDogs dogs=new MultiLevelDogs("Tommy");
            dogs.Eat();
            dogs.Walk();
            dogs.Sleep();
        }
    }
}
