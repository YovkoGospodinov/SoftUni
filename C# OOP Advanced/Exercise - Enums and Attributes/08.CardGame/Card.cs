namespace _08.CardGame
{
    using System;

    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
        }

        public Rank Rank
        {
            get { return this.rank; }
            private set
            {
                if (!Enum.IsDefined(typeof(Rank), value))
                {
                    throw new ArgumentException("No such card exists.");
                }

                this.rank = value;
            }
        }

        public Suit Suit
        {
            get { return this.suit; }
            private set
            {
                if (!Enum.IsDefined(typeof(Suit), value))
                {
                    throw new ArgumentException("No such card exists.");
                }

                this.suit = value;
            }
        }

        public int GetCardPower()
        {
            return (int) this.Rank + (int) this.Suit;
        }

        public int CompareTo(Card other)
        {
            return this.GetCardPower().CompareTo(other.GetCardPower());
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}