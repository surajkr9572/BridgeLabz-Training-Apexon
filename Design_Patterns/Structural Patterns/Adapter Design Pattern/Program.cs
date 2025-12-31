namespace Adapter_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var unknown = new Compound();
            unknown.Display();
            var water = new RichCompound(Chemical.Water);
            water.Display();
            var benzene = new RichCompound(Chemical.Benzene);
            benzene.Display();
            var ethanol = new RichCompound(Chemical.Ethanol);
            ethanol.Display();

        }
    }
}
