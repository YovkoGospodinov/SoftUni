namespace _07.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Human> people = new List<Human>();

            for (int i = 0; i < n; i++)
            {
                string[] humanDetails = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (humanDetails.Length == 4)
                {
                    string name = humanDetails[0];
                    int age = int.Parse(humanDetails[1]);
                    string id = humanDetails[2];
                    string birthDate = humanDetails[3];
                    Human currentPerson = new Person(name, age, id, birthDate);
                    people.Add(currentPerson);
                }
                else
                {
                    string name = humanDetails[0];
                    int age = int.Parse(humanDetails[1]);
                    string group = humanDetails[2];
                    Human currentRebel = new Rebel(name, age, group);
                    people.Add(currentRebel);
                }
            }

            string nameCommand = Console.ReadLine();

            while (nameCommand != "End")
            {
                people.FirstOrDefault(x => x.Name == nameCommand)?.BuyFood();

                //var searchHuman = people.FirstOrDefault(x => x.Name == nameCommand);
                //if (searchHuman != null)
                //{
                //    searchHuman.BuyFood();

                    //foreach (var person in people)
                    //{
                    //    if (person.Equals(searchHuman))
                    //    {
                    //        person.BuyFood();
                    //    }
                    //}
                //}
                nameCommand = Console.ReadLine();
            }

            var sumOfFood = people.Sum(x => x.Food);

            Console.WriteLine(sumOfFood);
        }
    }
}
