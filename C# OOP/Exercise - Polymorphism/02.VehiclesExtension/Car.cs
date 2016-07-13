namespace _02.VehiclesExtension
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
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

        
    }
}
