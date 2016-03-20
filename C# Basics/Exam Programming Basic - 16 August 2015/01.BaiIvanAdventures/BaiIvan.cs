using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BaiIvanAdventures
{
    class BaiIvan
    {
        static void Main()
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            decimal cash = decimal.Parse(Console.ReadLine());
            decimal desiredAlcohol = decimal.Parse(Console.ReadLine());
            decimal alcoholPerLitter = 0m;
            decimal boughtAlcohol = 0m;
            string drunklevel = string.Empty;

            switch (dayOfWeek)
            {
                case 0:
                    alcoholPerLitter = 25.0m;
                    break;
                case 1:
                    alcoholPerLitter = 21.0m;
                    break;
                case 2:
                    alcoholPerLitter = 14.0m;
                    break;
                case 3:
                    alcoholPerLitter = 17.0m;
                    break;
                case 4:
                    alcoholPerLitter = 45.0m;
                    break;
                case 5:
                    alcoholPerLitter = 59.0m;
                    break;
                case 6:
                    alcoholPerLitter = 42.0m;
                    break;
                default:
                    break;
            }
            boughtAlcohol = cash / alcoholPerLitter;

            if (boughtAlcohol > 1.5m)
            {
                drunklevel = "very drunk";
            }
            else if (boughtAlcohol <= 1.5m && boughtAlcohol >= 1.0m)
            {
                drunklevel = "drunk";
            }
            else
            {
                drunklevel = "sober";
            }

            if (boughtAlcohol > desiredAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", drunklevel, boughtAlcohol - desiredAlcohol);
            }
            else if (boughtAlcohol == desiredAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", drunklevel);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", drunklevel, desiredAlcohol - boughtAlcohol);
            }
        }
    }
}
