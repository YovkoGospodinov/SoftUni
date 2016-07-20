namespace _04.GenericSwapMethodStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Box<string>> myList = new List<Box<string>>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                var box = new Box<string>(input);
                myList.Add(box);
            }

            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Swap(myList, indexes[0], indexes[1]);
            myList.ForEach(x => Console.WriteLine(x));
        }

        public static void Swap<T>(List<T> data, int first, int second)
        {
            var temp = data[first];
            data[first] = data[second];
            data[second] = temp;
        }
    }
}
