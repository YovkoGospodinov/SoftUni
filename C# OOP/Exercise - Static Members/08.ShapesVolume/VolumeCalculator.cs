namespace _08.ShapesVolume
{
    using System; 

    public class VolumeCalculator
    {
        public static double Cube(double side)
        {
            return side * side * side;
        }

        public static double Cylinder(double radius, double height)
        {
            return Math.PI * height * radius * radius;
        }

        public static double TriangularPrism(double baseSide, double height, double length)
        {
            return 0.5 * baseSide * height * length;
        }
    }
}
