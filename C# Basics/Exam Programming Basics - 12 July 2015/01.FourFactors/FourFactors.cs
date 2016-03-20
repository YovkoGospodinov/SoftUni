using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FourFactors
{
    class FourFactors
    {
        static void Main()
        {
            double fieldGoals = double.Parse(Console.ReadLine());
            double fieldGoalAttempts = double.Parse(Console.ReadLine());
            double threePointsFieldGoals = double.Parse(Console.ReadLine());
            double turnovers = double.Parse(Console.ReadLine());
            double offensiveRebounds = double.Parse(Console.ReadLine());
            double oppDefensiveRebounds = double.Parse(Console.ReadLine());
            double freeThrows = double.Parse(Console.ReadLine());
            double freeThrowsAttempts = double.Parse(Console.ReadLine());

            double eFG = (fieldGoals + 0.5 * threePointsFieldGoals) / fieldGoalAttempts;
            double tOV = turnovers / (fieldGoalAttempts + 0.44 * freeThrowsAttempts + turnovers);
            double oRB = offensiveRebounds / (offensiveRebounds + oppDefensiveRebounds);
            double fT = freeThrows / fieldGoalAttempts;

            Console.WriteLine("eFG% {0:F3}", eFG);
            Console.WriteLine("TOV% {0:F3}", tOV);
            Console.WriteLine("ORB% {0:F3}", oRB);
            Console.WriteLine("FT% {0:F3}", fT);
        }
    }
}
