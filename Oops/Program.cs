using Oops.Constructor;
using Oops.Static_NonStatic;
using Oops.Inheritance.SingleLevelExample;
using Oops.Inheritance.MultiLevelExample;
using Oops.CustomeImmutableClass;
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

            //MultiLevelDogs dogs=new MultiLevelDogs("ayush");
            //dogs.Eat();
            //dogs.Walk();
            //dogs.Sleep();
            List<string>hobbies= new List<string>();
            hobbies.Add("Coding");
            hobbies.Add("Music");
            hobbies.Add("Sleeping");
            ImmutableClass imc = new ImmutableClass("Suraj",23,hobbies,12340);
            Console.WriteLine($"Name : {imc.Name}");
            Console.WriteLine($"Age  : {imc.Age}");
            Console.WriteLine($"Salary : {imc.Salary}");
            Console.WriteLine("Hobbies : ");
            foreach(var i in imc.Hobbies)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            hobbies.Add("Cricket");
            Console.WriteLine("After modifing original list : ");
            foreach( var i in imc.Hobbies)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
        }
    }
}
