namespace _07.CarSalesman
{
    using System.Text;

    public class Car
    {
        private string model;
        private Engine engine;
        private int weight; //private int? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight) 
            : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
           : this(model, engine, weight)
        {
            this.Color = color;
        }

        //public Car(string model, Engine engine, int? weight = null, string color = null)
        //{
        //    this.Model = model;
        //    this.Engine = engine;
        //    this.Weight = weight;
        //    this.Color = color;
        //}

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            private set
            {
                this.engine = value;
            }
        }

        public int Weight //public int? Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                this.weight = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format($"{this.Model}:"));
            result.AppendLine(string.Format($"  {this.Engine.Model}:"));
            result.AppendLine(string.Format($"    Power: {this.Engine.Power}"));

            if (this.Engine.Displacement != 0)
            {
                result.AppendLine(string.Format($"    Displacement: {this.Engine.Displacement}"));
            }
            else
            {
                result.AppendLine(string.Format($"    Displacement: n/a"));
            }

            if (this.Engine.Efficiency != null)
            {
                result.AppendLine(string.Format($"    Efficiency: {this.Engine.Efficiency}"));
            }
            else
            {
                result.AppendLine(string.Format($"    Efficiency: n/a"));
            }

            if (this.Weight != 0)
            {
                result.AppendLine(string.Format($"  Weight: {this.Weight}"));
            }
            else
            {
                result.AppendLine(string.Format($"  Weight: n/a"));
            }

            if (this.Color != null)
            {
                result.AppendLine(string.Format($"  Color: {this.Color}"));
            }
            else
            {
                result.AppendLine(string.Format($"  Color: n/a"));
            }
            return result.ToString();
        }
    }
}
