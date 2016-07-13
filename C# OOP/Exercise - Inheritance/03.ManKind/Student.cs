namespace _03.ManKind
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]) && !char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }
                this.facultyNumber = value;
            }
        }

        public override string GetDesription()
        {
            StringBuilder description = new StringBuilder();
            description.Append(base.GetDesription());
            description.AppendLine(String.Format($"Faculty number: {this.FacultyNumber}"));

            return description.ToString();
        }
    }
}
