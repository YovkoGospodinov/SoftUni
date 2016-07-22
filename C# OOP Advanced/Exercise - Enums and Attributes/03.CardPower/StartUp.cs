using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CardPower
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var rank = (RankPowers) Enum.Parse(typeof(RankPowers), input);

            input = Console.ReadLine();
            var suit = (SuitPower)Enum.Parse(typeof(SuitPower), input);


            var card = new Card(rank, suit);

            Console.WriteLine($"Card name: {card.Rank} of {card.Suit}; Card power: {card.GetPower()}");
        }
    }
}
