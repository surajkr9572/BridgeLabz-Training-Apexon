namespace Builder_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            // Construct and display vehicles
            shop.Construct(new MotorCycleBuilder());
            shop.ShowVehicle();

            shop.Construct(new CarBuilder());
            shop.ShowVehicle();
        }
    }
}
