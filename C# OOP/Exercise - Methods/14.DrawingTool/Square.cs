namespace _14.DrawingTool
{
    using System;

    public class Square : Shape
    {
        public int side;

        public Square(int side)
        {
            this.side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"|{new string('-', this.side)}|");
            for (int i = 0; i < this.side - 2; i++)
            {
                Console.WriteLine($"|{new string(' ', this.side)}|");
            }
            Console.WriteLine($"|{new string('-', this.side)}|");
        }
    }
}
