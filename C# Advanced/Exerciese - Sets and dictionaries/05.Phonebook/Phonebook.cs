namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            //Dictionary<string, string> phonebook = new Dictionary<string, string>();

            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    if (input == "search")
            //    {
            //        input = Console.ReadLine();
            //        while (true)
            //        {
            //            if (input == "stop")
            //            {
            //                Environment.Exit(0);
            //            }
            //            if (phonebook.ContainsKey(input))
            //            {
            //                Console.WriteLine($"{input} -> {phonebook[input]}");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Contact {input} does not exist.");
            //            }
            //            input = Console.ReadLine();
            //        }
            //    }
            //    else if (input == "stop")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        string[] splittedInput = input.Split('-');
            //        if (!phonebook.ContainsKey(splittedInput[0]))
            //        {
            //            phonebook.Add(splittedInput[0], splittedInput[1]);
            //        }
            //        else
            //        {
            //            phonebook[splittedInput[0]] = splittedInput[1];
            //        }
            //    }
            //}

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "stop" && input != "search")
            {
                string[] splittedInput = input.Split('-');
                string name = splittedInput[0];
                string phoneNumber = splittedInput[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = string.Empty;
                }

                phonebook[name] = phoneNumber;

                input = Console.ReadLine();
            }

            while (input != "stop")
            {
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
            }
        }
    }
}
