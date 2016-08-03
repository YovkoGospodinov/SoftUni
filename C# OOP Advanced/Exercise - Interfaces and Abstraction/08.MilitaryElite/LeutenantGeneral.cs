namespace _08.MilitaryElite
{
    using System.Collections.Generic;
    using _08.MilitaryElite.Contracts;
    using System.Text;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, IList<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public IList<Private> Privates { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Privates:");

            foreach (var currentPrivate in this.Privates)
            {
                result.AppendLine($"  {currentPrivate.ToString()}");
            }

            return  result.ToString().Trim();
        }
    }
}