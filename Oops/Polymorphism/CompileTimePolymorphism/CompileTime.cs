using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.Polymorphism.CompileTimePolymorphism
{
    internal class CompileTime
    {
        public CompileTime()
        {
            Console.WriteLine("CompileTime Polymorphism..");
        }
        public int sum(int a,int b)
        {
            return a + b;
        }
        public int sum(int a,int b,int c)
        {
            return a + b + c;
        }
        public int sum(int a,int b,int c,int d)
        {
            return a + b + c + d;
        }
        public int sum(int a)
        {
            return a;
        }
    }
}
