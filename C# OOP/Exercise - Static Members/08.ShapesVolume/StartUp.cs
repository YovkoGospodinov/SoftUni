namespace _08.ShapesVolume
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                double result = 0;

                if (splittedInput[0] == "Cube")
                {
                    double side = double.Parse(splittedInput[1]);
                    result = VolumeCalculator.Cube(side);
                }
                else if (splittedInput[0] == "Cylinder")
                {
                    double radius = double.Parse(splittedInput[1]);
                    double height = double.Parse(splittedInput[2]);
                    result = VolumeCalculator.Cylinder(radius, height);
                }
                else
                {
                    double baseSide = double.Parse(splittedInput[1]);
                    double height = double.Parse(splittedInput[2]);
                    double length = double.Parse(splittedInput[3]);
                    result = VolumeCalculator.TriangularPrism(baseSide, height, length);
                }

                Console.WriteLine("{0:F3}", result);

                input = Console.ReadLine();
            }
        }
    }
}
