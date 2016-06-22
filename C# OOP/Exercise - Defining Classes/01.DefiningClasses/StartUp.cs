using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace _01.DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            //Type personType = typeof(Person);
            //FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            //Console.WriteLine(fields.Length);


            //Type personType = typeof(Person);
            //ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            //ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            //ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            //bool swapped = false;
            //if (nameAgeCtor == null)
            //{
            //    nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            //    swapped = true;
            //}

            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            //Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            //Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            //Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            //Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            //Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            //Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);


            //var peshoPerson = new Person
            //{
            //    name = "Pesho",
            //    age = 20
            //};

            //var goshoPerson = new Person
            //{
            //    name = "Gosho",
            //    age = 18
            //};

            //var stamatPerson = new Person();
            //stamatPerson.name = "Stamat";
            //stamatPerson.age = 43;

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
