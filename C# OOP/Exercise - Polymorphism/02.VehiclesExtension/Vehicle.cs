namespace _02.VehiclesExtension
{
    using System;

    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = TankCapacity;
        }

        public virtual double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            set
            {
                this.fuelQuantity = value;
            }
        }

        public virtual double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }

            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }

            set
            {
                this.tankCapacity = value;
            }
        }

        public abstract void Drive(double kilometers);


        public virtual void Refuel(double liters)
        {
            if (this.TankCapacity < liters)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
            if (this.FuelQuantity < 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
