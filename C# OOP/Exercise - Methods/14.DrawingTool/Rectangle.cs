namespace _14.DrawingTool
{
    using System;

    public class Rectangle : Shape
    {
        private int width;
        private int heigth;

        public Rectangle(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public override void Draw()
        {
            Console.WriteLine($"|{new string('-', this.width)}|");
            for (int i = 0; i < this.heigth - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', this.width)}|");
            }
            Console.WriteLine($"|{new string('-', this.width)}|");
        }
    }
}
