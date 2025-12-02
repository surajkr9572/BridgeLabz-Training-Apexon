using BasicC_Concepts.DataTypes;
using BasicC_Concepts.ConditionalStatement;
using BasicC_Consepts.ConditionalStatement;
using BasicC_Consepts.Loops;
namespace BasicC_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datatype obj1= new Datatype();
            obj1.DataTypeExample();

            CoinsProblem obj2 = new CoinsProblem();
            int flip=int.Parse(Console.ReadLine());
            obj2.ConditionalExample(flip); 

            LeapYear lp=new LeapYear(2002);
            lp.LeapYearExample();

            PowerMethodUse p=new PowerMethodUse();
            int n=int.Parse(Console.ReadLine());
            p.PowerMethod(n);
        }
    }
}
