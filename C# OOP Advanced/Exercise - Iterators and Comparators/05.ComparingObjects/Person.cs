namespace _05.ComparingObjects
{
    using System;

    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public string Name => this.name;
        public int Age => this.age;
        public string Town => this.town;

        public int CompareTo(Person other)
        {
            if (this.name == other.name)
            {
                if (this.age == other.age)
                {
                    if (this.town == other.town)
                    {
                        return 0;
                    }

                    return this.town.CompareTo(other.town);
                }

                return this.age.CompareTo(other.age);
            }

            return this.name.CompareTo(other.name);
        }
    }
}