using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();
            int count = 1;
            string resourceName = "";
            while (true)
            {
                string input = Console.ReadLine().Trim();
                
                if (count % 2 != 0)
                {
                    resourceName = input;
                }
                if (input == "stop")
                {
                    break;
                }
                if (count % 2 != 0)
                {
                    if (!resources.ContainsKey(input))
                    {
                        resources.Add(input, 0);
                    }
                }
                else
                {
                    if (resources.ContainsKey(resourceName))
                    {
                        resources[resourceName] = int.Parse(input);
                    }
                }
                count++;
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
