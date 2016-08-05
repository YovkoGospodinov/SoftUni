namespace _07.EqualityLogic
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            return this.Name + " " + this.Age;
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                return false;
            }

            if (this.CompareTo(other) == 0)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Age ^ 231;
        }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
        }
    }
}