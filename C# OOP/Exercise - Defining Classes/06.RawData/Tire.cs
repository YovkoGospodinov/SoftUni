namespace _06.RawData
{
    public class Tire
    {
        public double pressure;
        public int age;

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }

            private set
            {
                this.pressure = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }
    }
}
