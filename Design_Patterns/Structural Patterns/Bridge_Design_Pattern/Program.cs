namespace Bridge_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new Customers(
            new CustomersData("Patna"));
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Ram");
            customers.ShowAll();
        }
    }
}
