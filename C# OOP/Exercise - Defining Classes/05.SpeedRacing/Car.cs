namespace _05.SpeedRacing
{
    using System;

    public class Car
    {
        private string model;
        private double fuelAmount;
        private double costForKilometer;
        private int distanceTraveled;

        public Car(string model, double fuelAmount, double costForKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.CostForKilometer = costForKilometer;
            this.DistanceTraveled = 0;
        }

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

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }

            private set
            {
                this.fuelAmount = value;
            }
        }

        public double CostForKilometer
        {
            get
            {
                return this.costForKilometer;
            }

            private set
            {
                this.costForKilometer = value;
            }
        }

        public int DistanceTraveled
        {
            get
            {
                return this.distanceTraveled;
            }

            private set
            {
                this.distanceTraveled = value;
            }
        }

        public void Drive(int kilometers)
        {
            if (this.FuelAmount < kilometers * this.CostForKilometer)
            {
                throw new ArgumentException("Insufficient fuel for the drive");
            }
            this.FuelAmount -= kilometers * this.CostForKilometer;
            this.DistanceTraveled += kilometers;
        }
    }
}
