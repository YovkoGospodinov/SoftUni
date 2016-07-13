namespace _02.BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string author, string title , double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get { return this.author; }
            protected set
            {
                string[] names = value.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (names.Length > 1)
                {
                    string secondName = names[1];
                    var firstLetter = secondName[0];
                    if (char.IsDigit(firstLetter))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                
                this.author = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder description = new StringBuilder();

            description.Append("Type: ").Append(this.GetType().Name)
                        .Append(Environment.NewLine)
                        .Append("Title: ").Append(this.Title)
                        .Append(Environment.NewLine)
                        .Append("Author: ").Append(this.Author)
                        .Append(Environment.NewLine)
                        .Append("Price: ").Append($"{this.Price:F1}")
                        .Append(Environment.NewLine);


            return description.ToString();
        }
    }
}
