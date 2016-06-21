namespace _07.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, string> emailData = new Dictionary<string, string>();

            string input = Console.ReadLine();
            int count = 0;
            string currentName = string.Empty;

            while (input != "stop")
            {
                if (count % 2 == 0)
                {
                    currentName = input;

                    if (!emailData.ContainsKey(currentName))
                    {
                        emailData[currentName] = string.Empty;
                    }
                }
                else
                {
                    emailData[currentName] = input;
                }

                count++;
                input = Console.ReadLine();
            }

            Dictionary<string, string> newData = new Dictionary<string, string>();

            foreach (var kvp in emailData)
            {
                if (!kvp.Value.Contains(".us"))
                {
                    newData.Add(kvp.Key, kvp.Value);
                }
            }

            foreach (var kvp in newData)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
