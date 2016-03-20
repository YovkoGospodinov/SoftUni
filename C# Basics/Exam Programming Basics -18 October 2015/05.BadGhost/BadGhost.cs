using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BadGhost
{
    class BadGhost
    {
        static void Main()
        {
            uint floor;
            //int[] apartmentsStrings;
            string[] apartmentsStrings;
            int[] apartments;
            string floorStr = Console.ReadLine();
            int totalLights = 0;
            long score = 0;
            while (floorStr != "Stop, God damn it")
            {
                floor = uint.Parse(floorStr);
                //apartmentsStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); 
                apartmentsStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                apartments = new int[apartmentsStrings.Length];
                for (int i = 0; i < apartmentsStrings.Length; i++)
                {
                    apartments[i] = int.Parse(apartmentsStrings[i]);
                }
                //Turning on/off lights
                for (int i = 0; i < apartments.Length; i++)
                {
                    uint mask = 1;
                    mask = mask << apartments[i];
                    mask = floor & mask;// 
                    if (mask == 0)
                    {
                        mask = 1;
                        mask = mask << apartments[i];
                        floor = floor | mask; // 
                    }
                    else
                    {
                        mask = ~mask;
                        floor = floor & mask;
                    }
                }

                //Counting lights on
                for (int i = 0; i < 32; i++)
                {
                    int mask = 1;
                    mask = mask << i;
                    if ((floor & mask) != 0)
                    {
                        totalLights++;
                    }
                }

                score += floor;
                floorStr = Console.ReadLine();
            }
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", totalLights, score);
        }
    }
}
