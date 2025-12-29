namespace Singleton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2= LoadBalancer.GetLoadBalancer();
            var b3= LoadBalancer.GetLoadBalancer();
            var b4= LoadBalancer.GetLoadBalancer();
            if(b1==b2 && b2==b3 && b3 == b4)
            {
                Console.WriteLine("Same Instance");
            }
            var balancer=LoadBalancer.GetLoadBalancer();
            for(int i = 0; i < 15; i++)
            {
                var server=balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to : "+server);
            }
        }
    }
}
