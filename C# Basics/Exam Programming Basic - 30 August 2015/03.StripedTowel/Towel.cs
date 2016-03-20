using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StripedTowel
{
    class Towel
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = (int)Math.Floor(width * 1.5D);

            string outputString = "";
            for (int i = 0; i < Math.Ceiling((width * height) / 3.0); i++)
            {
                outputString += "#..";
            }

            for (int row = 0; row < height; row++)
            {
                string stringToPrint = outputString.Substring(row * width, width);
                Console.WriteLine(stringToPrint);
            }

            //Another solution
            //int width = int.Parse(Console.ReadLine());
            //int height = (int)Math.Floor(width * 1.5D);

            //for (int row = 0; row < height; row++)
            //{
            //    for (int cow = 0; cow < width; cow++)
            //    {
            //        if ((row + cow) % 3 == 0)
            //        {
            //            Console.Write('#');
            //        }
            //        else
            //        {
            //            Console.Write('.');
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
