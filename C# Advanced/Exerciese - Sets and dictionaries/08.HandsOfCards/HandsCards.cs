namespace _08.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsCards
    {
        public static void Main()
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
                    cardsDatabase[playerName] = new HashSet<string>();
                }

                foreach (var card in cards)
                {
                    cardsDatabase[playerName].Add(card);
                }
            }

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var kvp in cardsDatabase)
            {
                var name = kvp.Key;
                var cards = kvp.Value;
                int points = 0;

                foreach (var card in cards)
                {
                    string power = string.Empty;
                    string type = string.Empty;

                    if (card.Length == 2)
                    {
                        power = card.Substring(0, 1);
                        type = card.Substring(1);
                    }
                    else
                    {
                        power = card.Substring(0, 2);
                        type = card.Substring(2);
                    }
                    

                    switch (power)
                    {
                        case "2":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 2);
                                    break;
                                case "H":
                                    points += (3 * 2);
                                    break;
                                case "D":
                                    points += (2 * 2);
                                    break;
                                case "C":
                                    points += (1 * 2);
                                    break;
                            }
                            break;
                        case "3":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 3);
                                    break;
                                case "H":
                                    points += (3 * 3);
                                    break;
                                case "D":
                                    points += (2 * 3);
                                    break;
                                case "C":
                                    points += (1 * 3);
                                    break;
                            }
                            break;
                        case "4":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 4);
                                    break;
                                case "H":
                                    points += (3 * 4);
                                    break;
                                case "D":
                                    points += (2 * 4);
                                    break;
                                case "C":
                                    points += (1 * 4);
                                    break;
                            }
                            break;
                        case "5":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 5);
                                    break;
                                case "H":
                                    points += (3 * 5);
                                    break;
                                case "D":
                                    points += (2 * 5);
                                    break;
                                case "C":
                                    points += (1 * 5);
                                    break;
                            }
                            break;
                        case "6":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 6);
                                    break;
                                case "H":
                                    points += (3 * 6);
                                    break;
                                case "D":
                                    points += (2 * 6);
                                    break;
                                case "C":
                                    points += (1 * 6);
                                    break;
                            }
                            break;
                        case "7":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 7);
                                    break;
                                case "H":
                                    points += (3 * 7);
                                    break;
                                case "D":
                                    points += (2 * 7);
                                    break;
                                case "C":
                                    points += (1 * 7);
                                    break;
                            }
                            break;
                        case "8":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 8);
                                    break;
                                case "H":
                                    points += (3 * 8);
                                    break;
                                case "D":
                                    points += (2 * 8);
                                    break;
                                case "C":
                                    points += (1 * 8);
                                    break;
                            }
                            break;
                        case "9":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 9);
                                    break;
                                case "H":
                                    points += (3 * 9);
                                    break;
                                case "D":
                                    points += (2 * 9);
                                    break;
                                case "C":
                                    points += (1 * 9);
                                    break;
                            }
                            break;
                        case "10":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 10);
                                    break;
                                case "H":
                                    points += (3 * 10);
                                    break;
                                case "D":
                                    points += (2 * 10);
                                    break;
                                case "C":
                                    points += (1 * 10);
                                    break;
                            }
                            break;
                        case "J":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 11);
                                    break;
                                case "H":
                                    points += (3 * 11);
                                    break;
                                case "D":
                                    points += (2 * 11);
                                    break;
                                case "C":
                                    points += (1 * 11);
                                    break;
                            }
                            break;
                        case "Q":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 12);
                                    break;
                                case "H":
                                    points += (3 * 12);
                                    break;
                                case "D":
                                    points += (2 * 12);
                                    break;
                                case "C":
                                    points += (1 * 12);
                                    break;
                            }
                            break;
                        case "K":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 13);
                                    break;
                                case "H":
                                    points += (3 * 13);
                                    break;
                                case "D":
                                    points += (2 * 13);
                                    break;
                                case "C":
                                    points += (1 * 13);
                                    break;
                            }
                            break;
                        case "A":
                            switch (type)
                            {
                                case "S":
                                    points += (4 * 14);
                                    break;
                                case "H":
                                    points += (3 * 14);
                                    break;
                                case "D":
                                    points += (2 * 14);
                                    break;
                                case "C":
                                    points += (1 * 14);
                                    break;
                            }
                            break;
                        }
                    }
                if (!result.ContainsKey(name))
                {
                    result[name] = 0;
                }

                result[name] += points;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
