using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "search")
                {
                    input = Console.ReadLine();
                    while (true)
                    {
                        if (input == "stop")
                        {
                            Environment.Exit(0);
                        }
                        if (phonebook.ContainsKey(input))
                        {
                            Console.WriteLine($"{input} -> {phonebook[input]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input} does not exist.");
                        }
                        input = Console.ReadLine();
                    }
                }
                else if (input == "stop")
                {
                    break;
                }
                else
                {
                    string[] splittedInput = input.Split('-');
                    if (!phonebook.ContainsKey(splittedInput[0]))
                    {
                        phonebook.Add(splittedInput[0], splittedInput[1]);
                    }
                    else
                    {
                        phonebook[splittedInput[0]] = splittedInput[1];
                    }
                }
            }
        }
    }
}
