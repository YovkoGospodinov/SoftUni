using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Passion_Days
{
    class PassionDays
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string entryCommand = Console.ReadLine();
            int purchases = 0;
            while (entryCommand != "mall.Enter")
            {
                entryCommand = Console.ReadLine();
            }

            string purchaseCommand = Console.ReadLine();

            while (purchaseCommand != "mall.Exit")
            {
                for (int i = 0; i < purchaseCommand.Length; i++)
                {
                    if (purchaseCommand[i] >= 65 && purchaseCommand[i] <= 90)
                    {
                        if (money >= purchaseCommand[i] / 2.0m)
                        {
                            money -= purchaseCommand[i] / 2.0m;
                            purchases++;
                        }
                    }
                    else if (purchaseCommand[i] >= 97 && purchaseCommand[i] <= 122)
                    {
                        if (money >= purchaseCommand[i] * 0.3m)
                        {
                            money -= purchaseCommand[i] * 0.3m;
                            purchases++;
                        }
                    }
                    else if (purchaseCommand[i] == 37)
                    {
                        if (money > 0)
                        {
                            money -= money / 2;
                            purchases++;
                        }
                    }
                    else if (purchaseCommand[i] == 42)
                    {
                        money += 10;
                    }
                    else
                    {
                        if (money >= purchaseCommand[i])
                        {
                            money -= purchaseCommand[i];
                            purchases++;
                        }
                    }
                }

                purchaseCommand = Console.ReadLine();
            }

            if (purchases > 0)
            {
                Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", purchases, money);
            }
            else
            {
                Console.WriteLine("No purchases. Money left: {0:F2} lv.", money);
            }

        }
    }
}
