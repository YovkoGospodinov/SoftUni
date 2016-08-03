namespace _09.CollectionHierarchy
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            int removes = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myListCollection = new MyList();

            foreach (var word in words)
            {
                Console.Write($"{addCollection.Add(word)} ");
            }
            Console.WriteLine();

            foreach (var word in words)
            {
                Console.Write($"{addRemoveCollection.Add(word)} ");
            }
            Console.WriteLine();

            foreach (var word in words)
            {
                Console.Write($"{myListCollection.Add(word)} ");
            }
            Console.WriteLine();

            for (int i = 0; i < removes; i++)
            {
                Console.Write($"{addRemoveCollection.Remove()} ");
            }
            Console.WriteLine();

            for (int i = 0; i < removes; i++)
            {
                Console.Write($"{myListCollection.Remove()} ");
            }
            Console.WriteLine();
        }
    }
}
