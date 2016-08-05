using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main()
        {
            var boxes = new List<Box<string>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();

                var currentBox = new Box<string>(input);

                boxes.Add(currentBox);
            }

            var elementToCompare = Console.ReadLine();

            var numberOfElementsGreater = Compare(boxes, elementToCompare);

            Console.WriteLine(numberOfElementsGreater);
        }

        public static int Compare(List<Box<string>> boxes, string element)
        {
            int numberOfGreaterElement = 0;

            foreach (var box in boxes)
            {
                if (string.Compare(box.Data, element) > 0)
                {
                    numberOfGreaterElement++;
                }
            }

            return numberOfGreaterElement;
        }
    }
}
