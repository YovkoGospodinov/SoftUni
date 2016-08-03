namespace _08.MilitaryElite
{
    using System.Collections.Generic;
    using System.Text;
    using _08.MilitaryElite.Contracts;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private IList<Mission> missions;

        public Commando(string id, string firstName, string lastName, double salary, string corps, IList<Mission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IList<Mission> Missions { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine("Missions:");

            foreach (var currentMission in this.Missions)
            {
                result.AppendLine(currentMission.ToString());
            }

            return result.ToString().Trim();
        }
    }
}