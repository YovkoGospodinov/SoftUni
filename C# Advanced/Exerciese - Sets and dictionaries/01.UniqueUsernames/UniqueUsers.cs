namespace _01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    public class UniqueUsers
    {
        public static void Main()
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
