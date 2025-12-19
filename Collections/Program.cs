using Collections.List;
using Collections.Queue;
using Collections.Stack;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomeList<int> numbers = new CustomeList<int>();

            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(40);
            //numbers.Add(50); 

            //Console.WriteLine("Count: " + numbers.Count);

            //numbers.print();
            //numbers.Remove(2);
            //numbers.print();

            //CustomStack<int> num = new CustomStack<int>(4);
            //num.push(1);
            //num.push(2);
            //num.push(3);
            //num.push(4);
            //Console.WriteLine(num.pop());
            //Console.WriteLine(num.IsFull());
            //num.push(5);
            //Console.WriteLine(num.IsFull());
            //Console.WriteLine(num.IsEmpty());
            //Console.WriteLine(num.peek());


            CustomQueue<int> num = new CustomQueue<int>(4);
            num.Enqueue(1);
            num.Enqueue(2);
            num.Enqueue(3);
            num.Enqueue(4);
            Console.WriteLine(num.Dequeue());
            Console.WriteLine(num.IsFull());
            num.Enqueue(5);
            Console.WriteLine(num.IsFull());
            Console.WriteLine(num.IsEmpty());
            Console.WriteLine(num.peek());

        }
    }
}
