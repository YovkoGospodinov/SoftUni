namespace _05.CardCompareTo
{
    using System;

    public class Card : IComparable<Card>
    {
        private RankPower rank;
        private SuitPower suit;

        public Card(RankPower rank, SuitPower suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public RankPower Rank { get; }

        public SuitPower Suit { get; }

        public int GetPower()
        {
            return (int)this.Rank + (int)this.Suit;
        }

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.GetPower()}";
        }

        public int CompareTo(Card otherCard)
        {
            return this.GetPower().CompareTo(otherCard.GetPower());
        }
    }
}