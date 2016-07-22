namespace _06.CustomEnumAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        private string type;
        private string category;
        private string description;

        public TypeAttribute(string type, string category, string description)
        {
            this.type = type;
            this.category = category;
            this.description = description;
        }

        public string Type => this.type;
        public string Category => this.category;
        public string Description => this.description;

        public override string ToString()
        {
            return $"Type = {this.type}, Description = {this.description}.";
        }
    }
}