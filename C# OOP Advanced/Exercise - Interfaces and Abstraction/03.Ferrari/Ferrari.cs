using System;
using System.Text;

namespace _03.Ferrari
{
    public class Ferrari : ICar
    {
        private static string model;

        static Ferrari()
        {
            model = "488-Spider";
        }

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver { get; private set; }
        public string Model => model;

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            StringBuilder description = new StringBuilder();

            description.Append(string.Format($"{this.Model}/{this.UseBrakes()}/{this.PushGas()}/{this.Driver}"));

            return description.ToString();
        }
    }
}