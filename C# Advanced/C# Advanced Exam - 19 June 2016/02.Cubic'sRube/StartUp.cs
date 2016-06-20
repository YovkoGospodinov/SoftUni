namespace _02.Cubic_sRube
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int totalCells = 1;

            long totalDamage = 0;

            for (int i = 0; i < 3; i++)
            {
                totalCells *= size;
            }

            string input = Console.ReadLine();

            while (input != "Analyze")
            {
                string[] commands = input.Split();

                int x = int.Parse(commands[0]);
                int y = int.Parse(commands[1]);
                int z = int.Parse(commands[2]);

                long damage = long.Parse(commands[3]);

                if ((x>=0 && x<size) && (y>=0 && y<size) && (z>=0 && z<size))
                {
                    
                    if (damage > 0)
                    {
                        totalDamage += damage;
                        totalCells--;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(totalDamage);
            Console.WriteLine(totalCells);
        }
    }
}
