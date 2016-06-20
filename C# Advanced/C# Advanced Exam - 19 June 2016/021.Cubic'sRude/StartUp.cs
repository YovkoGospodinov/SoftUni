namespace _021.Cubic_sRube
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int totalPoints = 1;
            long totalCells = 0;

            for (int i = 0; i < 3; i++)
            {
                totalPoints *= size;
            }
            
            long[,,] cube = new long[size, size, size];

            string input = Console.ReadLine();

            while (input != "Analyze")
            {
                string[] splittedInput = input.Split(' ');

                int x = int.Parse(splittedInput[0]);
                int y = int.Parse(splittedInput[1]);
                int z = int.Parse(splittedInput[2]);

                long cells = long.Parse(splittedInput[3]);
                
                if ((x >= 0 && x < size) && (y >= 0 && y < size) && (z >= 0 && z < size))
                {
                    if (cells > 0)
                    {
                        totalCells += cells;
                        totalPoints--;
                    }
                }

                input = Console.ReadLine();
            } 

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    for (int z = 0; z < size; z++)
                    {
                        totalCells += cube[x, y, z];
                    }
                }
            }
            Console.WriteLine(totalCells);
            Console.WriteLine(totalPoints);
        }
    }
}
