using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Design_Pattern
{
    public class MathProxy:IMath
    {
        private readonly Math math = new();

        public double Add(double x, double y)
        {
            Thread.Sleep(800);
            return math.Add(x , y);
        }
        public double Subtract(double x, double y)
        {
            Thread.Sleep(800);
            return math.Subtract(x , y);
        }
        public double Multiply(double x, double y)
        {
            Thread.Sleep(800);
            return math.Multiply(x , y);
        }
        public double Divide(double x, double y)
        {
            Thread.Sleep(800);
            return math.Divide(x , y);
        }
    }
}
