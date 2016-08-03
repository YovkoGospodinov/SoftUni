namespace _08.MilitaryElite
{
    using System.Collections.Generic;
    using _08.MilitaryElite.Contracts;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private IList<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, double salary, string corps, IList<Repair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }
        
        public IList<Repair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Repairs:");

            foreach (var currentRepair in this.Repairs)
            {
                result.AppendLine(currentRepair.ToString());
            }
            
            return result.ToString().Trim();
        }
    }
}