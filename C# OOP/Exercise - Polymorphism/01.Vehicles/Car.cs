namespace _01.Vehicles
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double kilometers)
        {
            double posibleTravelKm = base.FuelQuantity / (base.FuelConsumption + 0.9);
            if (posibleTravelKm >= kilometers)
            {
                base.FuelQuantity -= kilometers * (base.FuelConsumption + 0.9);
                Console.WriteLine($"Car travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            base.FuelQuantity += liters;
        }
    }
}
