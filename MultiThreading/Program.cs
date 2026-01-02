namespace MultiThreading
{
    internal class Program
    {
        //static void Method1()
        //{
        //    Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine("Method1 :" + i);
        //    }
        //    Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
        //}
        //static void Method2()
        //{
        //    Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine("Method2 :" + i);
        //        if (i == 3)
        //        {
        //            Console.WriteLine("Performing the Database Operation Started");
        //            //Sleep for 10 seconds
        //            Thread.Sleep(10000);
        //            Console.WriteLine("Performing the Database Operation Completed");
        //        }
        //    }
        //    Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
        //}
        //static void Method3()
        //{
        //    Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine("Method3 :" + i);
        //    }
        //    Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
        //}
        //static void method1()
        //{

        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("Method 1 : " + i);
        //    }
        //}
        //static void method2(CancellationToken cts)
        //{
        //    try
        //    {
        //        for (int i = 1; i <= 5; i++)
        //        {
        //            if (cts.IsCancellationRequested)
        //            {
        //                Console.WriteLine("Mathod 2 Cancelled Safely");
        //                return;
        //            }
        //            Thread.Sleep(1000);
        //            Console.WriteLine("Method 2 : " + i);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("mathod2 Aborted");

        //    }
        //}
        //static void method3()
        //{

        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("Method 3 : " + i);
        //    }
        //}
        //public void DisplayNumbers(object mx)
        //{
        //    int n = Convert.ToInt32(mx);
        //    for(int i = 1; i <= n; i++)
        //    {
        //        Console.WriteLine("Method1 : "+i);
        //    }
        //}

        //--------------------------------------------------------------Async-----------------------------------------------------------------------------
        //public static void Fun()
        //{
        //    Console.WriteLine("Fun Methods Start : ");
        //    Thread.Sleep(TimeSpan.FromSeconds(10)); //window size freeze for 10 seconds
        //    Console.WriteLine("\n");
        //    Console.WriteLine("Fun Methods End : ");

        //}
        //static async Task fun()
        //{
        //    Console.WriteLine("Hii");
        //}
        //static async Task fun2()
        //{
        //    await Task.Delay(10000);
        //    Console.WriteLine("Hello");
        //}
        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\nSome Method End");
        }

        private static async Task Wait()
        {
            Console.WriteLine("hiiii");
           await Task.Delay(TimeSpan.FromSeconds(4));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }
        static async Task Main(string[] args)
        {

            ////---------------------------------------------------Abort--------------------------------------
            //Console.WriteLine("Main Method Started...");
            //Fun();
            //Console.WriteLine("Main Method End");


            //Console.WriteLine("Start");
            //await fun();
            //Console.WriteLine("Stop");
            //await fun2();


            Console.WriteLine("Main Method Started");
            await Wait();
            // Calling async void method (fire-and-forget)
            SomeMethod();

            // Calling async Task method with await
            Thread.Sleep(5000);

            Console.WriteLine("Main Method End");
          

            // ---------------------------------------------------------------------------------------------------

            //CancellationTokenSource cts=new CancellationTokenSource();
            //Thread t1=new Thread(method1);
            //Thread t2=new Thread(()=>method2(cts.Token));
            //Thread t3=new Thread(method3);
            //t1.Start();
            //t2.Start(); 
            //t3.Start();

            //Thread.Sleep(1000);
            //cts.Cancel(); ;


            //Thread t=Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine("Current Executing Thread Name : "+t.Name);
            //Console.WriteLine("Current Executing Thread Name : "+Thread.CurrentThread.Name);
            //method1();
            //method2();
            //method3();
            //Console.WriteLine("Main Thread Started");
            ////Creating Threads
            //Thread t1 = new Thread(Method1)
            //{
            //    Name = "Thread1"
            //};
            //Thread t2 = new Thread(Method2)
            //{
            //    Name = "Thread2"
            //};
            //Thread t3 = new Thread(Method3)
            //{
            //    Name = "Thread3"
            //};
            ////Executing the methods
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //Console.WriteLine("Main Thread Ended");
            //Thread t1 = new Thread(ThreadClass.method1);
            //t1.Start();
            //ThreadStart obj=new ThreadStart(ThreadClass.method1);
            //Thread t1=new Thread(obj);
            //t1.Start();

            //Thread t1 = new Thread(delegate ()
            //{
            //    for(int i = 1; i <=5; i++)
            //    {
            //        Console.WriteLine("Method1 : "+i);
            //    }
            //});
            //t1.Start();

            //--------------------------------------------Thread Function with Parameter in C#:---------------------------------------------------
            //Program pg=new Program();
            ////Thread t1 = new Thread(pg.DisplayNumbers);   

            ////t1.Start(5);

            //ParameterizedThreadStart PT=new ParameterizedThreadStart(pg.DisplayNumbers);
            //Thread t1=new Thread(PT);
            //t1.Start(5);
        }
    }
}
