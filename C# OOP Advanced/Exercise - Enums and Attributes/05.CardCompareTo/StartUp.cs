namespace _05.CardCompareTo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var cards = new SortedSet<Card>();

            string inputLine1 = Console.ReadLine();
            string inputLine2 = Console.ReadLine();

            var rank = (RankPower)Enum.Parse(typeof(RankPower), inputLine1);
            var suit = (SuitPower)Enum.Parse(typeof(SuitPower), inputLine2);

            var firstCard = new Card(rank, suit);
            cards.Add(firstCard);

            inputLine1 = Console.ReadLine();
            inputLine2 = Console.ReadLine();
            rank = (RankPower)Enum.Parse(typeof(RankPower), inputLine1);
            suit = (SuitPower)Enum.Parse(typeof(SuitPower), inputLine2);

            var secondCard = new Card(rank, suit);
            cards.Add(secondCard);

            var greaterCard = cards.Last();

            Console.WriteLine(greaterCard.ToString());

        }
    }
}
