namespace _09.Google
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public string name;
        public Company company;
        public Car car;
        public List<Parent> parent;
        public List<Children> children;
        public List<Pokemon> pokemon;

        public Person(string name)
        {
            this.name = name;
            this.parent = new List<Parent>();
            this.children = new List<Children>();
            this.pokemon = new List<Pokemon>();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format($"{this.name}"));
            result.AppendLine(string.Format($"Company:"));
            if (this.company != null)
            {
                result.AppendLine(string.Format($"{this.company.name} {this.company.department} {this.company.salary:F2}"));
            }
            result.AppendLine(string.Format($"Car:"));
            if (this.car != null)
            {
                result.AppendLine(string.Format($"{this.car.name} {this.car.speed}"));
            }
            result.AppendLine(string.Format($"Pokemon:"));
            if (this.pokemon != null)
            {
                foreach (var pokemon in this.pokemon)
                {
                    result.AppendLine(string.Format($"{pokemon.name} {pokemon.type}"));
                }
            }
            result.AppendLine(string.Format($"Parents:"));
            if (this.parent != null)
            {
                foreach (var parent in this.parent)
                {
                    result.AppendLine(string.Format($"{parent.name} {parent.dateOfBirth}"));
                }
            }
            result.AppendLine(string.Format($"Children:"));
            if (this.children != null)
            {
                foreach (var children in this.children)
                {
                    result.AppendLine(string.Format($"{children.name} {children.dateOfBirth}"));
                }
            }

            return result.ToString();
        }
    }
}
