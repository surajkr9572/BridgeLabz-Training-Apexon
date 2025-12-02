using BasicC_Concepts.DataTypes;
using BasicC_Concepts.ConditionalStatement;
using BasicC_Consepts.ConditionalStatement;
namespace BasicC_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datatype obj1= new Datatype();
            obj1.DataTypeExample();

            CoinsProblem obj2 = new CoinsProblem();
            obj2.ConditionalExample(); 

            LeapYear lp=new LeapYear(2002);
            lp.LeapYearExample();
        }
    }
}
