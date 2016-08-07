namespace _09.TrafficLights
{
    public class Light
    {
        private SampleLights signal;

        public Light(SampleLights signal)
        {
            this.signal = signal;
        }

        public SampleLights Signal => this.signal;

        public void Change()
        {
            int currentSampleLight = (int) this.Signal;

            if (currentSampleLight > 1)
            {
                currentSampleLight = 0;
            }
            else
            {
                currentSampleLight++;
            }

            this.signal = (SampleLights) currentSampleLight;
        }
    }
}