namespace _03.ManKind
{
    using System;
    using System.Text;

    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                //if (value.Length < 4)
                //{
                //    throw new ArgumentException("Expected length at least 4 symbols!Argument:{0}", this.FirstName);
                //}
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                this.lastName = value;
            }
        }

        public virtual string GetDesription()
        {
            StringBuilder description = new StringBuilder();

            description.AppendLine(string.Format($"First Name: {this.FirstName}"));
            description.AppendLine(String.Format($"Last Name: {this.LastName}"));

            return description.ToString();
        }
    }
}
