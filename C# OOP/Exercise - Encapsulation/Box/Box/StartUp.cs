namespace Box
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                var firstBox = new Box(length, width, height);

                Console.WriteLine("Surface Area - {0:F2}", firstBox.SurfaceArea());
                Console.WriteLine("Lateral Surface Area - {0:F2}", firstBox.LateraSurface());
                Console.WriteLine("Volume - {0:F2}", firstBox.Volume());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
