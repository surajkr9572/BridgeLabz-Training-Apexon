namespace Factory_Method_Design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Document> documents = [new Resume(), new Report()];
            foreach(var  document in documents)
            {
                document.CreatePages();
                Console.WriteLine($"{document}---------");
                foreach(var i in document.Pages)
                {
                    Console.WriteLine($"{i}");
                }
                Console.WriteLine();
            }
        }
    }
}
