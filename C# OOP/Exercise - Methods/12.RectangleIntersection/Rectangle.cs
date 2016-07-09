namespace _12.RectangleIntersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double pointX;
        private double pointY;

        public Rectangle(string id, double width, double height, double pointX, double pointY)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.pointX = pointX;
            this.pointY = pointY;
        }

        public string Id => this.id;
        public double Width => this.width;
        public double Height => this.height;
        public double PointX => this.pointX;
        public double PointY => this.pointY;

        public static bool RectIntersect(Rectangle first, Rectangle second)
        {
            bool isIntersect = false;

            double firstPointAX = first.PointX;
            double firstPointAY = first.PointY;
            double firstPointBX = firstPointAX + first.Width;
            double firstPointBY = firstPointAY;
            double firstPointCX = firstPointBX;
            double firstPointCY = firstPointBY - first.Height;
            double firstPointDX = firstPointCX - first.Width;
            double firstPointDY = firstPointCY;


            double secondPointAX = second.PointX;
            double secondPointAY = second.PointY;
            double secondPointBX = secondPointAX + second.Width;
            double secondPointBY = secondPointAY;
            double secondPointCX = secondPointBX;
            double secondPointCY = secondPointBY - second.Height;
            double secondPointDX = secondPointCX - second.Width;
            double secondPointDY = secondPointCY;

            if ((((firstPointAX <= secondPointBX) && (firstPointAX >= secondPointAX)) && ((firstPointAY <= secondPointAY) && (firstPointAY >= secondPointDY))) || (((firstPointBX <= secondPointBX) && (firstPointBX >= secondPointAX)) && ((firstPointBY <= secondPointAY) && (firstPointBY >= secondPointDY))) || (((firstPointCX <= secondPointBX) && (firstPointCX >= secondPointAX)) && ((firstPointCY <= secondPointAY) && (firstPointCY >= secondPointDY))) || (((firstPointDX <= secondPointBX) && (firstPointDX >= secondPointAX)) && ((firstPointDY <= secondPointAY) && (firstPointDY >= secondPointDY))))
            {
                isIntersect = true;
            }

            return isIntersect;
        }
    }
}
