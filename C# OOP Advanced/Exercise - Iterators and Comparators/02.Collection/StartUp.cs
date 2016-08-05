namespace _02.Collection
{
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').Skip(1).ToArray();

            ListyIterator<string> collection = new ListyIterator<string>(input);

            string command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        Console.WriteLine(collection.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(collection.Move());
                        break;
                    case "Print":
                        collection.Print();
                        break;
                    case "PrintAll":
                        var result = new StringBuilder();

                        foreach (var element in collection)
                        {
                            result.Append(element + " ");
                        }

                        Console.WriteLine(result.ToString().Trim());

                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
