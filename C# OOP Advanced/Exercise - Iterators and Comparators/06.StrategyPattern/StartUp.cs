namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            SortedSet<Person> nameSortedPeople = new SortedSet<Person>();
            SortedSet<Person> ageSortedPeople = new SortedSet<Person>(new PersonAgeComparer());

            for (int i = 0; i < lines; i++)
            {
                string[] personDetails = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);

                var currentPerson = new Person(name, age);

                nameSortedPeople.Add(currentPerson);
                ageSortedPeople.Add(currentPerson);
            }

            foreach (var person in nameSortedPeople)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            foreach (var person in ageSortedPeople)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
