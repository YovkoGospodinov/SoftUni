using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyCalorieIntake
{
    class CalorieIntake
    {
        static void Main()
        {
            int weightPounds = int.Parse(Console.ReadLine());
            int heightInches = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int workoutsPerWeek = int.Parse(Console.ReadLine());

            double weightKilos = weightPounds / 2.2d;
            double heightCm = heightInches * 2.54d;
            double bmr = 0;

            if (gender == "m")
            {
                bmr = 66.5 + (13.75 * weightKilos) + (5.003 * heightCm) - (6.755 * age);
            }
            else
            {
                bmr = 655 + (9.563 * weightKilos) + (1.850 * heightCm) - (4.676 * age);
            }
            double multiplayer = 0;
            if (workoutsPerWeek <= 0)
            {
                multiplayer = 1.2;
            }
            else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
            {
                multiplayer = 1.375;
            }
            else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
            {
                multiplayer = 1.55;
            }
            else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
            {
                multiplayer = 1.725;
            }
            else
            {
                multiplayer = 1.9;
            }

            double dci = Math.Floor(multiplayer * bmr);

            Console.WriteLine(dci);
        }
    }
}
