using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Consepts.Loops
{
    internal class PowerMethodUse
    {
        public PowerMethodUse()
        {
            Console.WriteLine("Power method use here : ");
        }
        public void PowerMethod(int data)
        {
            if (data > 31)
            {
                Console.WriteLine("data overflow an int");
            }
            else
            {
               
                for(int i = 1; i <=data; i++)
                {
                    int tabel=Convert.ToInt32(Math.Pow(2, i));
                    Console.WriteLine($"2 ^ {i} = {tabel}" );
                }
            }
        }
    }
}
