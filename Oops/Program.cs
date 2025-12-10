using Oops.Constructor;
using Oops.CustomeImmutableClass;
using Oops.DeepCopy;
using Oops.Inheritance.MultiLevelExample;
using Oops.Inheritance.SingleLevelExample;
using Oops.Hiding.VariableHiding;
using Oops.Hiding.MethodHiding;
using Oops.ShawdowCopy;
using Oops.Polymorphism.CompileTimePolymorphism;
using Oops.Polymorphism.runTimePolymorphism;
using Oops.Static_NonStatic;
using System.Runtime.ConstrainedExecution;
using Oops.Polymorphism;

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

            //-----------------------------------------------------------Immutable Class-----------------------------------------------------------------------
            //List<string>hobbies= new List<string>();
            //hobbies.Add("Coding");
            //hobbies.Add("Music");
            //hobbies.Add("Sleeping");
            //ImmutableClass imc = new ImmutableClass("Suraj",23,hobbies,12340);
            //Console.WriteLine($"Name : {imc.Name}");
            //Console.WriteLine($"Age  : {imc.Age}");
            //Console.WriteLine($"Salary : {imc.Salary}");
            //Console.WriteLine("Hobbies : ");
            //foreach(var i in imc.Hobbies)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            //hobbies.Add("Cricket");
            //Console.WriteLine("After modifing original list : ");
            //foreach( var i in imc.Hobbies)
            //{
            //    Console.Write(i +" ");
            //}
            //Console.WriteLine();

            //----------------------------------------------------------Shawdow Copy------------------------------------------------------------------------------
            //CityForShallow ctShallow=new CityForShallow();
            //ctShallow.city = "Gopalganj";

            //PersonForShallow PFShallow=new PersonForShallow();
            //PFShallow.Name = "Suraj Singh";
            //PFShallow.adre = ctShallow;

            //PersonForShallow PFShallow1 = PFShallow.ShallowCopy();

            //PFShallow1.adre.city = "Lucknow";
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine($"Original Person Address: {PFShallow.adre.city}");
            //Console.WriteLine($"Copied Person Address : {PFShallow.adre.city}");

            //--------------------------------------------------------------Deep Copy-----------------------------------------------------------------------------------

            //Console.WriteLine("Deep Copy ....");
            //AddressForDeepCopy address = new AddressForDeepCopy();
            //address.city = "Gopalganj";
            //PersonForDeepCopy person = new PersonForDeepCopy();
            //person.Name = "Suraj Singh";
            //person.addr = address;

            //PersonForDeepCopy person1 = person.Deepcopy();
            //person1.addr.city = "Lucknow";

            //Console.WriteLine($"Original Person City : {person.addr.city}");
            //Console.WriteLine($"Copy Person City : {person1.addr.city}");

            //----------------------------------------------------------CompileTime Polymorphism----------------------------------------------------------------------------
            //Console.WriteLine("Compiletime polymorphism....");
            //CompileTime compiletime = new CompileTime();
            //Console.WriteLine(compiletime.sum(2));
            //Console.WriteLine(compiletime.sum(2, 4));
            //Console.WriteLine(compiletime.sum(2, 4, 6));
            //Console.WriteLine(compiletime.sum(2, 4, 6, 8));

            //--------------------------------------------------------runtime Polymorphism------------------------------------------------------------------------------------
            //runtimefile1 file1 = new runtimefile1();
            //file1.write();
            //file1 = new runtimefile2();
            //file1.write();
            //file1 = new runtimefile3();
            //file1.write();

            //--------------------------------------------------------Operator overloading------------------------------------------------------------------------------------
            //OperatorOverloading operatoroverloadingT1 = new OperatorOverloading(2,40);
            //OperatorOverloading operatoroverloadingT2 = new OperatorOverloading(1, 30);
            //OperatorOverloading Total = operatoroverloadingT1 + operatoroverloadingT2;
            //Console.WriteLine(Total);

            //---------------------------------------------------------Varible Hiding Concepts--------------------------------------------------------------------------------------
            //Console.WriteLine(Vchild.x);  //we can also hidding  non static variable and method
            //Console.WriteLine(Vperson.x);

            //---------------------------------------------------------Method Hiding Concepts------------------------------------------------------------------------------

            Mchild.show();
            Mperson.show();

        }
    }
}
