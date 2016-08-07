namespace _08.CardGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var firstPlayerName = Console.ReadLine();
            var secondPlayerName = Console.ReadLine();

            SortedSet<Card> firstPlayerCards = new SortedSet<Card>();
            SortedSet<Card> secondPlayerCards = new SortedSet<Card>();
            string[] cardDetails = Console.ReadLine().Split();

            while (firstPlayerCards.Count != 5)
            {
                try
                {
                    string rank = cardDetails[0];
                    string suit = cardDetails[2];

                    var currentCard = new Card(rank, suit);

                    var test = firstPlayerCards.SingleOrDefault(c => c.GetCardPower() == currentCard.GetCardPower());
                    if (test != null)
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }

                    firstPlayerCards.Add(currentCard);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("No such card exists.");
                }

                cardDetails = Console.ReadLine().Split();
            }

            while (secondPlayerCards.Count != 5)
            {
                try
                {
                    string rank = cardDetails[0];
                    string suit = cardDetails[2];

                    var currentCard = new Card(rank, suit);

                    var test = secondPlayerCards.SingleOrDefault(c => c.GetCardPower() == currentCard.GetCardPower());
                    if (test != null)
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }

                    secondPlayerCards.Add(currentCard);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("No such card exists.");
                }

                if (secondPlayerCards.Count != 5)
                {
                    break;
                }

                cardDetails = Console.ReadLine().Split();
            }

            int result = firstPlayerCards.Max.CompareTo(secondPlayerCards.Max);

            if (result >= 0)
            {
                Console.WriteLine($"{firstPlayerName} wins with {firstPlayerCards.Last().ToString()}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayerName} wins with {secondPlayerCards.Last().ToString()}.");
            }
        }
    }
}
