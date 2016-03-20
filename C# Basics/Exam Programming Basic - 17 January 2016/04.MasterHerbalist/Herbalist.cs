using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MasterHerbalist
{
    class Herbalist
    {
        static void Main()
        {
            decimal dailyexpenses = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int hours = 0;
            string path = "";
            decimal herbPrice = 0;
            int days = 0;
            decimal earnedMoney = 0;

            while (input != "Season Over")
            {
                string[] inputSplited = input.Split(' ');
                hours = int.Parse(inputSplited[0]);
                path = inputSplited[1];
                herbPrice = decimal.Parse(inputSplited[2]);
                int herb = 0;
                
                for (int i = 0; i < hours; i++)
                {
                    int letterIndex = i % path.Length;
                    if (path[letterIndex] == 'H')
                    {
                        herb++;
                    }
                }
                earnedMoney += herb * herbPrice;
                herb = 0;
                days++;
                input = Console.ReadLine();
            }
            decimal earnedMoneyPerDay = earnedMoney / days;

            if (earnedMoneyPerDay >= dailyexpenses)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:F2}.", earnedMoneyPerDay - dailyexpenses);
            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}.", (dailyexpenses * days) - (earnedMoney));
            }
        }
    }
}
