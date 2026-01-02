using System;
namespace MultiThreadingTask
{
    internal class Program
    {
        static void OrderPlacement()
        {
            Console.WriteLine("Validate cart items");
            Thread.Sleep(3000);
            Console.WriteLine("Create order record");
            Thread.Sleep(2000);
            Console.WriteLine("Confirm order details");
        }
        static void PaymentProcessing()
        {
            Console.WriteLine("Connect to payment gateway");
            Thread.Sleep(3000);
            Console.WriteLine("Handle success/failure");
            Thread.Sleep(2000);
            Console.WriteLine("Update payment status");
        }
        static void RestaurantNotification()
        {
            Console.WriteLine("Send order to restaurant");
            Thread.Sleep(3000);
            Console.WriteLine("Get acceptance");
            Thread.Sleep(2000);
            Console.WriteLine("Update preparation status");
        }
        static void DeliveryTracking()
        {
            Console.WriteLine("Assign delivery partner");
            Thread.Sleep(3000);
            Console.WriteLine("Track real-time location");
            Thread.Sleep(2000);
            Console.WriteLine("Update ETA");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(OrderPlacement);
            Thread t2 = new Thread(PaymentProcessing);
            Thread t3 = new Thread(RestaurantNotification);
            Thread t4 = new Thread(DeliveryTracking);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            Console.WriteLine("Order Flow Completed...");
        }
    }
}
