namespace Prototype_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new ColorManager();
            manager[ColorType.Red] = new Color { Red = 255, Blue = 0, Green = 0 };
            manager[ColorType.Green] = new Color { Red = 0, Blue = 255, Green = 0 };
            manager[ColorType.Blue] = new Color { Red = 0, Blue = 0, Green = 255 };
            manager[ColorType.Angry] = new Color { Red = 255, Blue = 54, Green = 0 };
            manager[ColorType.Peace] = new Color { Red = 128, Blue = 211, Green = 128 };
            manager[ColorType.Flame] = new Color { Red = 211, Blue = 34, Green = 20 };
            _ = manager[ColorType.Red].Clone();
            _ = manager[ColorType.Peace].Clone();
            _ = manager[ColorType.Flame].Clone(false);
        }
    }
}
