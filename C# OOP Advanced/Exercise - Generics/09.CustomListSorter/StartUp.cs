namespace _09.CustomListSorter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split();

            var data = new CustomList<string>();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Add":
                        data.AddElement(command[1]);
                        break;
                    case "Remove":
                        data.RemoveElement(int.Parse(command[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(data.ContainsElement(command[1]));
                        break;
                    case "Swap":
                        int first = int.Parse(command[1]);
                        int second = int.Parse(command[2]);
                        data.Swap(first, second);
                        break;
                    case "Greater":
                        Console.WriteLine(data.CountGreaterThan(command[1]));
                        break;
                    case "Max":
                        Console.WriteLine(data.MaxElement());
                        break;
                    case "Min":
                        Console.WriteLine(data.MinElement());
                        break;
                    case "Print":
                        foreach (var value in data.Values)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                    case "Sort":
                        Sorter.SortElements(data);
                        break;
                }


                command = Console.ReadLine().Split();
            }
        }
    }
}
