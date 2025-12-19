using Collections.List;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomeList<int> numbers = new CustomeList<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50); 

            Console.WriteLine("Count: " + numbers.Count);

            numbers.print();
            numbers.Remove(2);
            numbers.print();
        }
    }
}
