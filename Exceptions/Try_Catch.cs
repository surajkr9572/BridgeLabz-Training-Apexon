using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Try_Catch
    {
        public int a;
        public int b;
        public int c = 0;
        public Try_Catch(int a,int b)
        {
            this.a = a; 
            this.b = b;
        }
        public void fun()
        {
            try
            {
                c = a / b;
                Console.WriteLine("result : " + c);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Divide By zero Exception...");
            }
            finally
            {
                Console.WriteLine("Finally Block excuted...");
            }
        }
    }
}
