using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasketBattle
{
    class Basket
    {
        static void Main()
        {
            string playerFirstRound = Console.ReadLine();
            int gameRounds = int.Parse(Console.ReadLine());
            int scoreFirstPlayer = 0;
            int scoreSecondPlayer = 0;
            string firstPlayerName = "";
            string secondPlayerName = "";
            double count = 0;

            if (playerFirstRound == "Simeon")
            {
                firstPlayerName = "Simeon";
                secondPlayerName = "Nakov";
                for (int i = 0; i < gameRounds * 2; i++)
                {
                    int predictedPoints = int.Parse(Console.ReadLine());
                    string shootInfo = Console.ReadLine();
                    count++;
                    if (i % 2 == 0 && shootInfo == "success")
                    {
                        if (scoreFirstPlayer + predictedPoints <= 500)
                        {
                            scoreFirstPlayer += predictedPoints;
                        }
                    }
                    else if (i % 2 != 0 && shootInfo == "success")
                    {
                        if (scoreSecondPlayer + predictedPoints <= 500)
                        {
                            scoreSecondPlayer += predictedPoints;
                        }
                    }

                    if (i % 2 != 0)
                    {
                        int c = scoreFirstPlayer;
                        scoreFirstPlayer = scoreSecondPlayer;
                        scoreSecondPlayer = c;
                    }

                    if (scoreFirstPlayer >= 500 || scoreSecondPlayer >= 500)
                    {
                        break;
                    }
                }
            }
            else if (playerFirstRound == "Nakov")
            {
                firstPlayerName = "Nakov";
                secondPlayerName = "Simeon";
                for (int i = 0; i < gameRounds * 2; i++)
                {
                    int predictedPoints = int.Parse(Console.ReadLine());
                    string shootInfo = Console.ReadLine();
                    count++;
                    if (i % 2 == 0 && shootInfo == "success")
                    {
                        if (scoreFirstPlayer + predictedPoints <= 500)
                        {
                            scoreFirstPlayer += predictedPoints;
                        }
                    }
                    else if (i % 2 != 0 && shootInfo == "success")
                    {
                        if (scoreSecondPlayer + predictedPoints <= 500)
                        {
                            scoreSecondPlayer += predictedPoints;
                        }
                    }

                    if (i % 2 != 0)
                    {
                        int c = scoreFirstPlayer;
                        scoreFirstPlayer = scoreSecondPlayer;
                        scoreSecondPlayer = c;
                    }

                    if (scoreFirstPlayer >= 500 || scoreSecondPlayer >= 500)
                    {
                        break;
                    }
                }
                //Console.WriteLine(scoreFirstPlayer);
                //Console.WriteLine(scoreSecondPlayer);

            }
            if (scoreFirstPlayer >= 500 || scoreSecondPlayer >= 500)
            {
                if (scoreFirstPlayer > scoreSecondPlayer)
                {
                    Console.WriteLine(firstPlayerName);
                    Console.WriteLine("{0}", Math.Ceiling(count / 2));
                    Console.WriteLine(scoreSecondPlayer);
                }
                else if (scoreSecondPlayer > scoreFirstPlayer)
                {
                    Console.WriteLine(secondPlayerName);
                    Console.WriteLine("{0}", Math.Ceiling(count / 2));
                    Console.WriteLine(scoreFirstPlayer);
                }
            }
            else if (scoreFirstPlayer == scoreSecondPlayer)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(scoreFirstPlayer);
            }
            else if (scoreFirstPlayer != scoreSecondPlayer)
            {
                if (scoreFirstPlayer > scoreSecondPlayer)
                {
                    Console.WriteLine(firstPlayerName);
                    Console.WriteLine("{0}", scoreFirstPlayer - scoreSecondPlayer);
                }
                else
                {
                    Console.WriteLine(scoreSecondPlayer);
                    Console.WriteLine("{0}", scoreSecondPlayer - scoreFirstPlayer);
                }
            }
        }
    }
}
