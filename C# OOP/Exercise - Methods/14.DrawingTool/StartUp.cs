namespace _14.DrawingTool
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figure = Console.ReadLine();
            int width = int.Parse(Console.ReadLine());
            int heigth = 0;

            if (figure == "Rectangle")
            {
                heigth = int.Parse(Console.ReadLine());
                var rectangle = new Rectangle(width, heigth);
                rectangle.Draw();
            }
            else
            {
                var square = new Square(width);
                square.Draw();
            }
        }
    }
}
