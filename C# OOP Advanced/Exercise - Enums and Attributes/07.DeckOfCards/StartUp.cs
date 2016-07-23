namespace _07.DeckOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    var currentCard = new Card((Rank)j, (Suit)i);
                    cards.Add(currentCard);
                }
            }

            foreach (var card in cards)
            {
                Console.WriteLine(card.CardInfo());
            }
        }
    }
}
