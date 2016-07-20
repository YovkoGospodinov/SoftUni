namespace _05.GenericSwapMethodInt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Box<int>> myList = new List<Box<int>>();

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
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
