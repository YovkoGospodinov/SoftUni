namespace _13.PrintPeople
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] splittedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string personName = splittedInput[0];
                int personAge = int.Parse(splittedInput[1]);
                string personOccupation = splittedInput[2];

                var person = new Person(personName, personAge, personOccupation);

                people.Add(person);

                input = Console.ReadLine();
            }

            people.OrderBy(p => p.Age).ToList().ForEach(p => Console.WriteLine($"{p.Name} - age: {p.Age}, occupation: {p.Occupation}"));
        }
    }
}
