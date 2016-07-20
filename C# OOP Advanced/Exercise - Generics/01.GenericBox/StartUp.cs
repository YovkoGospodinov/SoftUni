namespace _01.GenericBox
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
                var box = new Box<object>(Console.ReadLine());
                Console.WriteLine(box.ToString());
        }
    }
}
