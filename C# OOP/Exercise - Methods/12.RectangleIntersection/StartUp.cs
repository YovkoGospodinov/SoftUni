namespace _12.RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            int[] lines = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < lines[0]; i++)
            {
                string[] rectdetails = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string rectId = rectdetails[0];
                double rectWidth = double.Parse(rectdetails[1]);
                double rectHeight = double.Parse(rectdetails[2]);
                double rectAX = double.Parse(rectdetails[3]);
                double rectAY = double.Parse(rectdetails[4]);

                var currentRect = new Rectangle(rectId, rectWidth, rectHeight, rectAX, rectAY);

                if (!rectangles.ContainsKey(rectId))
                {
                    rectangles.Add(rectId, currentRect);
                }
            }

            for (int i = 0; i < lines[1]; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var firstRect = rectangles[command[0]];
                var secondRect = rectangles[command[1]];

                Console.WriteLine(Rectangle.RectIntersect(firstRect, secondRect).ToString().ToLower());
            }
        }

        //public static bool RectIntersect(Rectangle first, Rectangle second)
        //{
        //    bool isIntersect = false;

        //    double firstPointAX = first.PointX;
        //    double firstPointAY = first.PointY;
        //    double firstPointBX = firstPointAX + first.Width;
        //    double firstPointBY = firstPointAY;
        //    double firstPointCX = firstPointBX;
        //    double firstPointCY = firstPointBY - first.Height;
        //    double firstPointDX = firstPointCX - first.Width;
        //    double firstPointDY = firstPointCY;


        //    double secondPointAX = second.PointX;
        //    double secondPointAY = second.PointY;
        //    double secondPointBX = secondPointAX + second.Width;
        //    double secondPointBY = secondPointAY;
        //    double secondPointCX = secondPointBX;
        //    double secondPointCY = secondPointBY - second.Height;
        //    double secondPointDX = secondPointCX - second.Width;
        //    double secondPointDY = secondPointCY;

        //    if ((((firstPointAX <= secondPointBX) && (firstPointAX >= secondPointAX)) && ((firstPointAY <= secondPointAY) && (firstPointAY >= secondPointDY))) || (((firstPointBX <= secondPointBX) && (firstPointBX >= secondPointAX)) && ((firstPointBY <= secondPointAY) && (firstPointBY >= secondPointDY))) || (((firstPointCX <= secondPointBX) && (firstPointCX >= secondPointAX)) && ((firstPointCY <= secondPointAY) && (firstPointCY >= secondPointDY))) || (((firstPointDX <= secondPointBX) && (firstPointDX >= secondPointAX)) && ((firstPointDY <= secondPointAY) && (firstPointDY >= secondPointDY))))
        //    {
        //        isIntersect = true;
        //    }

        //    return isIntersect;
        //}
    }
}
