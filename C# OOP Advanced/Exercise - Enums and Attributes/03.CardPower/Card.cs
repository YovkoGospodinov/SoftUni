namespace _03.CardPower
{
    public class Card
    {
        private RankPowers rank;
        private SuitPower suit;

        public Card(RankPowers rank, SuitPower suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public RankPowers Rank { get; }
        public SuitPower Suit { get; }

        public int GetPower()
        {
            return (int)this.Rank + (int)this.Suit;
        }
    }
}