namespace CardEnum
{
    internal class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            Card randomCard = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
            Console.WriteLine(randomCard.Name.ToString());
        }
    }
}
