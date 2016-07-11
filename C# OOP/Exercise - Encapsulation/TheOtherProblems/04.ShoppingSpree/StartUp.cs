namespace _04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(';');
            foreach (var person in peopleInput)
            {
                string[] personDetails = person.Split('=');
                string personName = personDetails[0];
                decimal personMoney = decimal.Parse(personDetails[1]);

                try
                {
                    var currentPerson = new Person(personName, personMoney);
                    people.Add(currentPerson);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            string[] productsInput = Console.ReadLine().Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var product in productsInput)
            {
                string[] productDetails = product.Split(new []{ '=' }, StringSplitOptions.RemoveEmptyEntries);
                string productName = productDetails[0];
                decimal productPrice = decimal.Parse(productDetails[1]);

                try
                {
                    var currentProduct = new Product(productName, productPrice);
                    products.Add(currentProduct);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            string purchases = Console.ReadLine();

            while (purchases != "END")
            {
                string[] splittedPurchase = purchases.Split(' ');
                string personName = splittedPurchase[0];
                string productName = splittedPurchase[1];

                decimal searchedPersonMoney = 0;
                string searchedPersonName = String.Empty;
                decimal searchedProductPrice = 0;
                string searchedProductName = String.Empty;
                int count = 0;
                
                foreach (var item in people)
                {
                    if (item.Name == personName)
                    {
                        searchedPersonMoney = item.Money;
                        searchedPersonName = item.Name;
                        break;
                    }
                    count++;
                }

                foreach (var item in products)
                {
                    if (item.Name == productName)
                    {
                        searchedProductPrice = item.Price;
                        searchedProductName = item.Name;
                    }
                }

                if (searchedPersonMoney >= searchedProductPrice)
                {
                    Console.WriteLine($"{searchedPersonName} bought {searchedProductName}");
                    people[count].AddProduct(new Product(searchedProductName, searchedProductPrice));
                }
                else
                {
                    Console.WriteLine($"{searchedPersonName} can't afford {searchedProductName}");
                }

                purchases = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    var personProducts = person.Products;
                    var items = new List<string>();

                    foreach (var item in personProducts)
                    {
                        items.Add(item.Name);
                    }

                    Console.WriteLine($"{person.Name} - {string.Join(", ", items)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
