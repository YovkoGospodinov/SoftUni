namespace _03.OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using OpinionPolls;
    public class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                var person = new Person(int.Parse(input[1]), input[0]);

                persons.Add(person);
            }

            persons.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList().ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
