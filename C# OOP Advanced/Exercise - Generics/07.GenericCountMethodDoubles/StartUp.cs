namespace _07.GenericCountMethodDoubles
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var boxes = new List<Box<double>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = double.Parse(Console.ReadLine());

                var currentBox = new Box<double>(input);

                boxes.Add(currentBox);
            }

            var elementToCompare = double.Parse(Console.ReadLine());

            var numberOfElementsGreater = Compare(boxes, elementToCompare);

            Console.WriteLine(numberOfElementsGreater);

        }

        public static int Compare(List<Box<double>> boxes, double element)
        {
            int numberOfGreaterElements = 0;

            foreach (var box in boxes)
            {
                if (box.Data > element)
                {
                    numberOfGreaterElements++;
                }
            }

            return numberOfGreaterElements;
        }
    }
}
