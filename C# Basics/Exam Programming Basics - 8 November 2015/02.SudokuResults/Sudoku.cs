using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SudokuResults
{
    class Sudoku
    {
        static void Main()
        {
            int counter = 0;
            double totalSeconds = 0;
            string input = Console.ReadLine();

            while (input != "Quit")
            {
                counter++;
                double minutes = double.Parse(input.Substring(0, 2));
                double seconds = double.Parse(input.Substring(3, 2));

                totalSeconds += (minutes * 60) + seconds;

                input = Console.ReadLine();
            }

            double average = Math.Ceiling(totalSeconds / counter);

            if (average < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (average >= 720 && average <= 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else if (average > 1440)
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, average);
        }
    }
}
