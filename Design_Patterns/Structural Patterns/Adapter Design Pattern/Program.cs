namespace Adapter_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            // Non-adapted chemical compound 
            var unknown = new Compound();
            unknown.Display();
            // Adapted chemical compounds
            var water = new RichCompound(Chemical.Water);
            water.Display();
            var benzene = new RichCompound(Chemical.Benzene);
            benzene.Display();
            var ethanol = new RichCompound(Chemical.Ethanol);

        }
    }
}
