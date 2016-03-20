using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.JoroTheFootballPlayer
{
    class Joro
    {
        static void Main()
        {
            string typeOfYear = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());

            double playHolidays = numberOfHolidays / 2D;
            int normalWeekends = 52 - hometownWeekends;
            double normalWeekendsNotTired = normalWeekends / 3D;
            double playWeekends = normalWeekendsNotTired * 2D;

            double totalPlays = playHolidays + playWeekends + hometownWeekends;
            if (typeOfYear == "t")
            {
                totalPlays += 3;
            }
            Console.WriteLine("{0}", Math.Floor(totalPlays));
        }
    }
}
