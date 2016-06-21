namespace _06.MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class MinerTask
    {
        static void Main()
        {
            Dictionary<string, BigInteger> resources = new Dictionary<string, BigInteger>();
            int count = 0;
            string input = Console.ReadLine().Trim();
            string currentResource = string.Empty;

            while (input != "stop")
            {
                if (count % 2 == 0)
                {
                    currentResource = input;

                    if (!resources.ContainsKey(currentResource))
                    {
                        resources[currentResource] = 0;
                    }
                }
                else
                {
                    resources[currentResource] += int.Parse(input);
                }

                count++;
                input = Console.ReadLine();
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
