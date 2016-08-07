using System.Collections.Generic;

namespace _09.TrafficLights
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            List<Light> traficLights = new List<Light>();

            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                var currentSampleLight = (SampleLights) Enum.Parse(typeof(SampleLights), item);
                var currentLight = new Light(currentSampleLight);

                traficLights.Add(currentLight);
            }

            int changes = int.Parse(Console.ReadLine());

            for (int i = 0; i < changes; i++)
            {
                string result = String.Empty;

                foreach (var trafficLight in traficLights)
                {
                    trafficLight.Change();
                    result += trafficLight.Signal;
                    result += " ";
                }

                Console.WriteLine(result.Trim());
            }
        }
    }
}
