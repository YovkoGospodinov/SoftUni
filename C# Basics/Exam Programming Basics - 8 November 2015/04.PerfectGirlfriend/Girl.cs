using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PerfectGirlfriend
{
    class Girl
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int counter = 0;
            int score = 0;
            while (input != "Enough dates!")
            {
                
                string[] girl = input.Split('\\');

                switch (girl[0])
                {
                    case "Monday":
                        score += 1;
                        break;
                    case "Tuesday":
                        score += 2;
                        break;
                    case "Wednesday":
                        score += 3;
                        break;
                    case "Thursday":
                        score += 4;
                        break;
                    case "Friday":
                        score += 5;
                        break;
                    case "Saturday":
                        score += 6;
                        break;
                    case "Sunday":
                        score += 7;
                        break;
                    default:
                        break;
                }

                for (int i = 0; i < girl[1].Length; i++)
                {
                    score += int.Parse(girl[1][i].ToString());
                    //score += (int)Char.GetNumericValue(girl[1][i]);
                    //score += girl[1][i] - '0';
                }

                int braDiameter = int.Parse(girl[2].Substring(0, girl[2].Length - 1));
                int braCup = (int)char.Parse(girl[2].Substring(girl[2].Length - 1, 1));
                score += braDiameter * braCup;
                
                int nameLetter = (int)char.Parse(girl[3].Substring(0, 1));
                int nameLenght = 0;
                for (int i = 0; i < girl[3].Length; i++)
                {
                    nameLenght++;
                }
                
                score -= nameLetter * nameLenght;

                if (score < 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", girl[3]);
                }
                else
                {
                    Console.WriteLine("{0} is perfect for you.", girl[3]);
                    counter++;
                }
                score = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
