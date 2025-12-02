using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Concepts.DataTypes
{
    internal class Datatype
    {
        public Datatype()
        {
            Console.WriteLine("Implementations of Datatype");
        }
        public void DataTypeExample()
        {
            byte b = 110;   //1 byte    0-255 2^8-1
            short sh = 1100; //2 bytes  -32768 to 32767 -2^15 to 2^15-1
            int i = 11100000;   //4 bytes  -2^31 to 2^31-1  
            long l = 1100020; //8 bytes  -2^63 to 2^63-1


            float f = 3.25f;  //4 bytes -2^31 to 2^31-1
            double d = 13.2333; //8 bytes -2^63 to 2^63-1
            decimal dec = 16.98m; //16bytes -2^127 to 2^127-1


            char ch='A';
            string s = "Suraj";

            Console.WriteLine("Byte : "+b);
            Console.WriteLine("Short : " + sh);
            Console.WriteLine("Integer : " + i);
            Console.WriteLine("Long : " + l);
            Console.WriteLine("Float : "+f);
            Console.WriteLine("Double : "+d);
            Console.WriteLine("Decimal : " + dec);
            Console.WriteLine("Character : " + ch);
            Console.WriteLine("String : " + s);
        }
    }
}
