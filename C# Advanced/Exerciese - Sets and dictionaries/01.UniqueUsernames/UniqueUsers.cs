using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UniqueUsernames
{
    class UniqueUsers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> database = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                database.Add(Console.ReadLine());
            }
            foreach (string username in database)
            {
                Console.WriteLine(username);
            }
        }
    }
}
