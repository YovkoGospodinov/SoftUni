namespace _01.CardSuit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var suits = Enum.GetValues(typeof(CardSuits));

            string input = Console.ReadLine();
            Console.WriteLine("Card Suits:");

            foreach (var suit in suits)
            {
                Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
            }

            //string input = Console.ReadLine();
            //Console.WriteLine("Card Suits:");

            //Console.WriteLine($"Ordinal value: {(int)CardSuits.Clubs}; Name value: {CardSuits.Clubs}");
            //Console.WriteLine($"Ordinal value: {(int)CardSuits.Diamonds}; Name value: {CardSuits.Diamonds}");
            //Console.WriteLine($"Ordinal value: {(int)CardSuits.Hearts}; Name value: {CardSuits.Hearts}");
            //Console.WriteLine($"Ordinal value: {(int)CardSuits.Spades}; Name value: {CardSuits.Spades}");
        }
    }
}
