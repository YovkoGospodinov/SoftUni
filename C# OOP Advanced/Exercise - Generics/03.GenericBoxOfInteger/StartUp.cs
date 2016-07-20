namespace _03.GenericBoxOfInteger
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                var box = new Box<int>(number);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
