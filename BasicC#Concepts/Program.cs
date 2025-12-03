using BasicC_Concepts.DataTypes;
using BasicC_Concepts.ConditionalStatement;
using BasicC_Consepts.ConditionalStatement;
using BasicC_Consepts.Loops;
using BasicC_Consepts.DataTypes;
namespace BasicC_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datatype obj1 = new Datatype();
            //obj1.DataTypeExample();

            //CoinsProblem obj2 = new CoinsProblem();
            //int flip = int.Parse(Console.ReadLine());
            //obj2.ConditionalExample(flip);

            //LeapYear lp = new LeapYear(2002);
            //lp.LeapYearExample();

            //PowerMethodUse p = new PowerMethodUse();
            //int n = int.Parse(Console.ReadLine());
            //p.PowerMethod(n);

            //HarmonicNumber HN = new HarmonicNumber();
            //int harmonic = int.Parse(Console.ReadLine());
            //HN.Harmonic(harmonic);

            //Console.WriteLine("Enter number for prime factor");
            //int num = int.Parse(Console.ReadLine());
            //PrimeFactor pm = new PrimeFactor();
            //pm.primefact(num);

            //Console.WriteLine("Enter Two digit for Quitent and reminder : ");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Quotient_Remainder qr = new Quotient_Remainder();
            //qr.Quotient(num1, num2);

            //Console.WriteLine("Swap two number : ");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //SwapTonumbers sn = new SwapTonumbers();
            //sn.Swap(num1, num2);

            //Console.WriteLine("Enter Number for odd or even : ");
            //int number = int.Parse(Console.ReadLine());
            //EvenOrOdd evenodd = new EvenOrOdd();
            //evenodd.evenorodd(number);

            //Console.WriteLine("Enter Character for check Whether present or not : ");
            //char ch = char.Parse(Console.ReadLine());
            //VowelorConsonant vc = new VowelorConsonant();
            //bool ans = vc.functionAlphabet(ch);
            //if ((ch > 'a' && ch < 'z') || (ch > 'A' && ch < 'Z'))
            //{
            //    if (ans)
            //    {
            //        Console.WriteLine("Alphabet is a vowel");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Alphabet is a consonant");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("This is not Alphabet");
            //}

            //Console.WriteLine("Enter three number for Largest");
            //int largest1 = int.Parse(Console.ReadLine());
            //int largest2 = int.Parse(Console.ReadLine());
            //int largest3 = int.Parse(Console.ReadLine());
            //Largest ls = new Largest();
            //ls.largestt(largest1, largest2, largest3);

            //Console.WriteLine("Enter number for fibonacci :");
            //int fibonacciNum = int.Parse(Console.ReadLine());
            //Fibonacci fb = new Fibonacci();
            //fb.fibonacci(fibonacciNum);


            //Console.WriteLine("Enter Perfect Number: ");
            //int perfectnum = int.Parse(Console.ReadLine());
            //PerfectNumber perfectnumber = new PerfectNumber();
            //if (perfectnumber.perfect(perfectnum))
            //{
            //    Console.WriteLine("Perfect Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not Perfect Number");
            //}
            //int primenum = int.Parse(Console.ReadLine());
            //PrimeNumber prnumber = new PrimeNumber();
            //if (prnumber.prime(primenum))
            //{
            //    Console.WriteLine("Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Prime Number");
            //}

            //int reverseNum = int.Parse(Console.ReadLine());
            //ReverseNumber revnum = new ReverseNumber();
            //int revans = revnum.reverse(reverseNum);
            //Console.WriteLine(revans);

            //int couponNum = int.Parse(Console.ReadLine());
            //CouponNumbers CN = new CouponNumbers();
            //Console.WriteLine(CN.Countrandom(couponNum));

            //SimulateStopwatch stopwatch = new SimulateStopwatch();
            //stopwatch.simulateTime();

            //int gradepercent=int.Parse(Console.ReadLine());
            //GradeProblem gd=new GradeProblem();
            //gd.Grade(gradepercent);

            //int temperature=int.Parse(Console.ReadLine());
            //ConvertsTemperatures ct=new ConvertsTemperatures();
            //ct.temperatureConvert(temperature);

            //int age=int.Parse(Console.ReadLine());
            //TicketPrice tp=new TicketPrice();
            //tp.ticketPrice(age);

            //checkthecredentials cc=new checkthecredentials();
            //cc.check();

            //Console.WriteLine("Enter First Number");
            //int cl1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //int cl2=int.Parse(Console.ReadLine());
            //Calculate cl=new Calculate();
            //cl.calculater(cl1, cl2);

            //Console.WriteLine("Enter rock,paper,scissors");
            //string st=Console.ReadLine();
            //rockPaper rp=new rockPaper();
            //rp.rock(st);


            //Console.WriteLine("Enter overdue Days: ");
            //int overdays=int.Parse(Console.ReadLine());
            //LibraryBooks lb=new LibraryBooks();
            //lb.library(overdays);

            Console.WriteLine("This is Trafic light instraction...");
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.light();
        }
    }
}
