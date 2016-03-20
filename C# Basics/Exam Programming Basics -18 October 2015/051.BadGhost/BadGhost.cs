using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051.BadGhost
{
    class BadGhost
    {
        static void Main()
        {
            string inputFloor = Console.ReadLine();
            long finalScore = 0;
            long lights = 0;
            long inputFloorNumber = 0;
            while (inputFloor != "Stop, God damn it")
            {
                int[] inputCommand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                inputFloorNumber = long.Parse(inputFloor);                

                for (int i = 0; i < inputCommand.Length; i++)
                {
                    inputFloorNumber ^= 1L << inputCommand[i];
                }

                finalScore += inputFloorNumber;
                for (int i = 0; i < 32; i++)
                {
                    if ((inputFloorNumber >> i & 1) == 1)
                    {
                        lights++;
                    }
                }

                inputFloor = Console.ReadLine();
            }
            
           
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", lights, finalScore);
        }
    }
}
