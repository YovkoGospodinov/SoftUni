namespace _04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Products => this.products;

        public void AddProduct(Product product)
        {
            this.products.Add(product);
            this.money -= product.Price;
        }
    }
}
