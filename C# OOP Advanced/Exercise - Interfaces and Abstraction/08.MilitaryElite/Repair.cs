namespace _08.MilitaryElite
{
    using System.Text;
    using _08.MilitaryElite.Contracts;

    public class Repair : IRepair
    {
        private string partName;
        private int hoursWorked;

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; }
        public int HoursWorked { get; }

        public override string ToString()
        {
            return $"  Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}