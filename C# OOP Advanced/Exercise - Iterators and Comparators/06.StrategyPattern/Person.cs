namespace _06.StrategyPattern
{
    using System;

    public class Person : IComparable<Person>
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => this.name;
        public int Age => this.age;

        public int CompareTo(Person other)
        {
            if (this.name.Length == other.name.Length)
            {
                if (this.name.ToLower()[0] == other.name.ToLower()[0])
                {
                    return 0;
                }

                return this.name.ToLower()[0].CompareTo(other.name.ToLower()[0]);
            }
            return this.name.Length.CompareTo(other.name.Length);
        }
    }
}