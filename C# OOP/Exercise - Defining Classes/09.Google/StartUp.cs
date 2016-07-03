namespace _09.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string data = Console.ReadLine().Trim();
            var people = new List<Person>();

            while (data != "End")
            {
                string[] details = data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string detailsType = details[1];
                string personName = details[0];
                bool personExist = false;


                foreach (var person in people)
                {
                    if (person.name == personName)
                    {
                        personExist = true;
                        break;
                    }
                }

                if (!personExist)
                {
                    var currentPerson = new Person(personName);

                    switch (detailsType)
                    {
                        case "company":
                            string currentCompanyName = details[2];
                            string currentCompanyDept = details[3];
                            decimal currentCompanySalary = decimal.Parse(details[4]);
                            var currentCompany = new Company(currentCompanyName, currentCompanyDept, currentCompanySalary);
                            currentPerson.company = currentCompany;
                            break;
                        case "car":
                            string currentCarName = details[2];
                            int currentCarSpeed = int.Parse(details[3]);
                            var currentCar = new Car(currentCarName, currentCarSpeed);
                            currentPerson.car = currentCar;
                            break;
                        case "pokemon":
                            string currentPokemonName = details[2];
                            string currentPokemonType = details[3];
                            var currentPokemon = new Pokemon(currentPokemonName, currentPokemonType);
                            currentPerson.pokemon.Add(currentPokemon);
                            break;
                        case "parents":
                            string currentParentName = details[2];
                            string currentParentBirthDate = details[3];
                            var currentParent = new Parent(currentParentName, currentParentBirthDate);
                            currentPerson.parent.Add(currentParent);
                            break;
                        case "children":
                            string currentChildName = details[2];
                            string currentChildBirthDate = details[3];
                            var currentChild = new Children(currentChildName, currentChildBirthDate);
                            currentPerson.children.Add(currentChild);
                            break;
                    }
                    people.Add(currentPerson);
                }
                else
                {
                    foreach (var person in people)
                    {
                        if (person.name == personName)
                        {
                            switch (detailsType)
                            {
                                case "company":
                                    string currentCompanyName = details[2];
                                    string currentCompanyDept = details[3];
                                    decimal currentCompanySalary = decimal.Parse(details[4]);
                                    var currentCompany = new Company(currentCompanyName, currentCompanyDept, currentCompanySalary);
                                    person.company = currentCompany;
                                    break;
                                case "car":
                                    string currentCarName = details[2];
                                    int currentCarSpeed = int.Parse(details[3]);
                                    var currentCar = new Car(currentCarName, currentCarSpeed);
                                    person.car = currentCar;
                                    break;
                                case "pokemon":
                                    string currentPokemonName = details[2];
                                    string currentPokemonType = details[3];
                                    var currentPokemon = new Pokemon(currentPokemonName, currentPokemonType);
                                    person.pokemon.Add(currentPokemon);
                                    break;
                                case "parents":
                                    string currentParentName = details[2];
                                    string currentParentBirthDate = details[3];
                                    var currentParent = new Parent(currentParentName, currentParentBirthDate);
                                    person.parent.Add(currentParent);
                                    break;
                                case "children":
                                    string currentChildName = details[2];
                                    string currentChildBirthDate = details[3];
                                    var currentChild = new Children(currentChildName, currentChildBirthDate);
                                    person.children.Add(currentChild);
                                    break;
                            }
                        }
                    }
                }
                data = Console.ReadLine().Trim();
            }
            string searchedName = Console.ReadLine().Trim();

            people.Where(p => p.name == searchedName).ToList().ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
