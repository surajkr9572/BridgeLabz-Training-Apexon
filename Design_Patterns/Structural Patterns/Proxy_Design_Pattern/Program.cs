namespace Proxy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proxy = new MathProxy();
            Console.WriteLine($"4 + 2 = {proxy.Add(4, 2)}");
            Console.WriteLine($"4 - 2 = {proxy.Subtract(4, 2)}");
            Console.WriteLine($"4 * 2 = {proxy.Multiply(4, 2)}");
            Console.WriteLine($"4 / 2 = {proxy.Divide(4, 2)}");
        }
    }
}
