namespace _05.ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                var name = input[0];
                var age = int.Parse(input[1]);
                var town = input[2];

                var currentPerson = new Person(name, age, town);

                people.Add(currentPerson);

                input = Console.ReadLine().Split();
            }

            int position = int.Parse(Console.ReadLine()) - 1;

            var searchedPerson = people[position];
            int numberOfMatches = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(searchedPerson) == 0)
                {
                    numberOfMatches++;
                }
            }
            
            int totalNumberOfPeople = people.Count;

            if (numberOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numberOfMatches} {totalNumberOfPeople - numberOfMatches} {totalNumberOfPeople}");
            }

        }
    }
}
