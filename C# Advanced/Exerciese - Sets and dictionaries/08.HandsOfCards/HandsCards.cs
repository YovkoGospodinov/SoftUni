using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HandsOfCards
{
    class HandsCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> cardsDatabase = new Dictionary<string, HashSet<string>>();
            while (true)
            {
                string input = Console.ReadLine().Trim();
                if (input == "JOKER")
                {
                    break;
                }
                string[] splittedInput = input.Split(':');
                string playerName = splittedInput[0].Trim();
                string[] cards = splittedInput[1].Trim().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!cardsDatabase.ContainsKey(playerName))
                {
                    cardsDatabase.Add(playerName, new HashSet<string>());
                }

            }
        }
    }
}
