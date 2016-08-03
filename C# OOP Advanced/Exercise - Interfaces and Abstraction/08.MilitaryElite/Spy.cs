using System;

namespace _08.MilitaryElite
{
    using _08.MilitaryElite.Contracts;

    public class Spy : Soldier, ISpy
    {
        private string codeNumber;

        public Spy(string id, string firstName, string lastName, string codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public string CodeNumber { get; }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Code Number: {this.CodeNumber}";
        }
    }
}