namespace _02.CardRank
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var ranks = Enum.GetValues(typeof(CardRank));

            string input = Console.ReadLine();

            Console.WriteLine($"{input}:");

            foreach (var rank in ranks)
            {
                Console.WriteLine($"Ordinal value: {(int)rank}; Name value: {rank}");
            }
        }
    }
}
