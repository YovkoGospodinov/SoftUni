namespace _06.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<IBeing> beings = new List<IBeing>();
            string entry = Console.ReadLine();

            while (entry != "End")
            {
                string[] entryDetails = entry.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (entryDetails[0] == "Citizen")
                {
                    string name = entryDetails[1];
                    int age = int.Parse(entryDetails[2]);
                    string id = entryDetails[3];
                    string birthDate = entryDetails[4];

                    IBeing currentCitizen = new Citizen(name, age, id, birthDate);
                    beings.Add(currentCitizen);
                }
                else if(entryDetails[0] == "Pet")
                {
                    string name = entryDetails[1];
                    string birthDate = entryDetails[2];

                    IBeing currentPet = new Pet(name, birthDate);
                    beings.Add(currentPet);
                }

                entry = Console.ReadLine();
            }

            string data = Console.ReadLine();

            beings.Where(x => x.BirthDate.EndsWith(data)).ToList().ForEach(x => Console.WriteLine(x.BirthDate));
        }
    }
}
