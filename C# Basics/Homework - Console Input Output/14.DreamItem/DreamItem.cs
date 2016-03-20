using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DreamItem
{
    class DreamItem
    {
        static void Main()
        {
            int daysInMonth = 0;
            string[] userInput = Console.ReadLine().Split('\\');

            if (userInput[0] == "Feb")
            {
                daysInMonth += 28;
            }
            else if (userInput[0] == "Apr" || userInput[0] == "June" || userInput[0] == "Sept" || userInput[0] == "Nov")
            {
                daysInMonth += 30;
            }
            else
            {
                daysInMonth += 31;
            }

            decimal moneyPerHour = decimal.Parse(userInput[1]);
            int hoursPerDay = int.Parse(userInput[2]);
            decimal itemPrice = decimal.Parse(userInput[3]);
            int workingDays = daysInMonth - 10;

            decimal earnedMoney = workingDays * moneyPerHour * hoursPerDay;

            if (earnedMoney > 700)
            {
                earnedMoney *= 1.1m;
            }

            if (earnedMoney >= itemPrice)
            {
                Console.WriteLine("Money left = {0:F2} leva.", Math.Abs(earnedMoney - itemPrice));
            }
            else
                Console.WriteLine("Not enough money. {0:F2} leva needed.", Math.Abs(earnedMoney - itemPrice));

        }
    }
}
