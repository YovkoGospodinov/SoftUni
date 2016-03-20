using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double hightMeters = double.Parse(Console.ReadLine());
            double widthMeters = double.Parse(Console.ReadLine());

            double hightSantimeters = hightMeters * 100;
            double widthSantimeters = widthMeters * 100;

            widthSantimeters -= 100;
            int deskOnRow = (int)widthSantimeters / 70;
            int rows = (int)hightSantimeters / 120;

            int desks = deskOnRow * rows;
            desks -= 3;
            Console.WriteLine(desks);             
        }
    }
}
