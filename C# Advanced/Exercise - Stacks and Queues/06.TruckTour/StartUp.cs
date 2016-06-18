namespace _06.TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<GasStation> gasStations = new Queue<GasStation>();

            for (int i = 0; i < n; i++)
            {
                int[] stationInfo = Console.ReadLine()
                    .Trim()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                GasStation station = new GasStation(stationInfo[0], stationInfo[1], i);

                gasStations.Enqueue(station);
            }

            GasStation startedStation = null;
            bool completeTour = false;

            while (true)
            {
                GasStation currentStation = gasStations.Dequeue();
                startedStation = currentStation;
                gasStations.Enqueue(currentStation);

                int gas = currentStation.gas;

                while (gas >= currentStation.distance)
                {
                    gas -= currentStation.distance;
                    currentStation = gasStations.Dequeue();
                    gasStations.Enqueue(currentStation);

                    if (currentStation == startedStation)
                    {
                        completeTour = true;
                        break;
                    }

                    gas += currentStation.gas;
                }

                if (completeTour)
                {
                    Console.WriteLine(currentStation.number);
                    break;
                }
            }
        }
    }

    public class GasStation
    {
        public int gas;
        public int distance;
        public int number;

        public GasStation(int gas, int distance, int number)
        {
            this.gas = gas;
            this.distance = distance;
            this.number = number;
        }
    }
}
