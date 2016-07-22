namespace _04.CardToString
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string inputLine1 = Console.ReadLine();
            string inputLine2 = Console.ReadLine();

            var rank = (RankPower)Enum.Parse(typeof(RankPower), inputLine1);
            var suit = (SuitPower) Enum.Parse(typeof(SuitPower), inputLine2);

            var card = new Card(rank, suit);

            Console.WriteLine(card.ToString());
        }
    }
}
