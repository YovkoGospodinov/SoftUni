namespace Emergency_Skeleton
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            while (command != "EmergencyBreak")
            {
                command = Console.ReadLine();
            }
        }
    }
}
