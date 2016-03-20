using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TheFootballStatistician
{
class Statistician
{
    static void Main()
    {
        decimal paymentPerMatchEuro = decimal.Parse(Console.ReadLine());

        string[] clubs = { "Arsenal", "Chelsea", "Everton", "Liverpool", "ManchesterCity", "ManchesterUnited", "Southampton", "Tottenham" };
            int matches = 0;
        int[] clubsPoint = new int[8];

        string matchInput = Console.ReadLine();

        while (matchInput != "End of the league.")
        {
            string[] matchInputSplited = matchInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (matchInputSplited[1])
            {
                case "1":
                        if (matchInputSplited[0] == "Arsenal")
                        {
                            clubsPoint[0] += 3;
                        }
                        else if (matchInputSplited[0] == "Chelsea")
                        {
                            clubsPoint[1] += 3;
                        }
                        else if (matchInputSplited[0] == "Everton")
                        {
                            clubsPoint[2] += 3;
                        }
                        else if (matchInputSplited[0] == "Liverpool")
                        {
                            clubsPoint[3] += 3;
                        }
                        else if (matchInputSplited[0] == "ManchesterCity")
                        {
                            clubsPoint[4] += 3;
                        }
                        else if (matchInputSplited[0] == "ManchesterUnited")
                        {
                            clubsPoint[5] += 3;
                        }
                        else if (matchInputSplited[0] == "Southampton")
                        {
                            clubsPoint[6] += 3;
                        }
                        else if (matchInputSplited[0] == "Tottenham")
                        {
                            clubsPoint[7] += 3;
                        }; 
                        break;
                case "2":
                        if (matchInputSplited[2] == "Arsenal")
                        {
                            clubsPoint[0] += 3;
                        }
                        else if (matchInputSplited[2] == "Chelsea")
                        {
                            clubsPoint[1] += 3;
                        }
                        else if (matchInputSplited[2] == "Everton")
                        {
                            clubsPoint[2] += 3;
                        }
                        else if (matchInputSplited[2] == "Liverpool")
                        {
                            clubsPoint[3] += 3;
                        }
                        else if (matchInputSplited[2] == "ManchesterCity")
                        {
                            clubsPoint[4] += 3;
                        }
                        else if (matchInputSplited[2] == "ManchesterUnited")
                        {
                            clubsPoint[5] += 3;
                        }
                        else if (matchInputSplited[2] == "Southampton")
                        {
                            clubsPoint[6] += 3;
                        }
                        else if (matchInputSplited[2] == "Tottenham")
                        {
                            clubsPoint[7] += 3;
                        };
                        break;
                case "X":
                        switch (matchInputSplited[0])
                        {
                            case "Arsenal":
                                clubsPoint[0] += 1;
                                break;
                            case "Chelsea":
                                clubsPoint[1] += 1;
                                break;
                            case "Everton":
                                clubsPoint[2] += 1;
                                break;
                            case "Liverpool":
                                clubsPoint[3] += 1;
                                break;
                            case "ManchesterCity":
                                clubsPoint[4] += 1;
                                break;
                            case "ManchesterUnited":
                                clubsPoint[5] += 1;
                                break;
                            case "Southampton":
                                clubsPoint[6] += 1;
                                break;
                            case "Tottenham":
                                clubsPoint[7] += 1;
                                break;
                            default:
                                break;
                        }
                        switch (matchInputSplited[2])
                        {
                            case "Arsenal":
                                clubsPoint[0] += 1;
                                break;
                            case "Chelsea":
                                clubsPoint[1] += 1;
                                break;
                            case "Everton":
                                clubsPoint[2] += 1;
                                break;
                            case "Liverpool":
                                clubsPoint[3] += 1;
                                break;
                            case "ManchesterCity":
                                clubsPoint[4] += 1;
                                break;
                            case "ManchesterUnited":
                                clubsPoint[5] += 1;
                                break;
                            case "Southampton":
                                clubsPoint[6] += 1;
                                break;
                            case "Tottenham":
                                clubsPoint[7] += 1;
                                break;
                            default:
                                break;
                        }
                        break;
                default:
                    break;
            }
                matches++;

            matchInput = Console.ReadLine();
        }

        Console.WriteLine("{0:F2}lv.", matches * paymentPerMatchEuro * 1.94m);
        Console.WriteLine("Arsenal - {0} points.", clubsPoint[0]);
        Console.WriteLine("Chelsea - {0} points.", clubsPoint[1]);
        Console.WriteLine("Everton - {0} points.", clubsPoint[2]);
        Console.WriteLine("Liverpool - {0} points.", clubsPoint[3]);
        Console.WriteLine("Manchester City - {0} points.", clubsPoint[4]);
        Console.WriteLine("Manchester United - {0} points.", clubsPoint[5]);
        Console.WriteLine("Southampton - {0} points.", clubsPoint[6]);
        Console.WriteLine("Tottenham - {0} points.", clubsPoint[7]);

        }
}
}
