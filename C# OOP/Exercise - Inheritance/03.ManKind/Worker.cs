namespace _03.ManKind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private double weekSalary;
        private double workingHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workingHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHoursPerDay = workingHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public double WorkingHoursPerDay
        {
            get
            {
                return this.workingHoursPerDay;
            }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workingHoursPerDay = value;
            }
        }

        public override string GetDesription()
        {
            StringBuilder description = new StringBuilder();
            description.Append(base.GetDesription());
            description.AppendLine(String.Format($"Week Salary: {this.WeekSalary:F2}"));
            description.AppendLine(String.Format($"Hours per day: {this.WorkingHoursPerDay:F2}"));
            description.AppendLine(String.Format($"Salary per hour: {(this.WeekSalary / (this.WorkingHoursPerDay * 5)):F2}"));

            return description.ToString();
        }
    }
}
