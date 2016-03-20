using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AniIsDrunk
{
    class Ani
    {
        static void Main()
        {
            long numberOfCabins = long.Parse(Console.ReadLine());
            string steps = Console.ReadLine();
            long currentPosition = 0;
            long totalSteps = 0;
            while (steps != "Found a free one!")
            {
                long stepss = int.Parse(steps);
                long oldPosition = currentPosition;
                currentPosition = (currentPosition + stepss) % numberOfCabins;
                long difference = currentPosition - oldPosition;

                if (difference > 0)
                {
                    Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference));
                }
                else if (difference < 0)
                {
                    Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }

                totalSteps += Math.Abs(difference);
                steps = Console.ReadLine();
            }

            Console.WriteLine("Moved a total of {0} steps.", totalSteps);


        }
    }
}
