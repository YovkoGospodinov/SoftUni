namespace _07.DeckOfCards
{
    public class Card
    {
        private Rank rank;
        private Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public string CardInfo()
        {
            return $"{this.rank} of {this.suit}";
        }
    }
}