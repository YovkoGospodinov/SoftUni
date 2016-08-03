namespace _08.MilitaryElite
{
    using System;
    using _08.MilitaryElite.Contracts;

    public class Mission : IMission
    {
        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.CadeName = codeName;
            this.State = state;
        }

        public string CadeName { get; }

        public string State
        {
            get { return this.state; }
            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("Invalid mission state.");
                }

                this.state = value;
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.CadeName} State: {this.State}";
        }
    }
}