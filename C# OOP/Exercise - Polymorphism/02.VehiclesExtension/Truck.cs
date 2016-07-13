namespace _02.VehiclesExtension
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double kilometers)
        {
            double posibleTravelKm = base.FuelQuantity / (base.FuelConsumption + 1.6);
            if (posibleTravelKm >= kilometers)
            {
                base.FuelQuantity -= kilometers * (base.FuelConsumption + 1.6);
                Console.WriteLine($"Truck travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            base.FuelQuantity += liters * 0.95;
        }
    }
}
