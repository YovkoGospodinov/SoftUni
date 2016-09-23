namespace EmergencySystem.Models
{
    using System;
    using System.Collections.Generic;
    using EmergencySystem.Attributes;
    using EmergencySystem.Contracts;
    
    [Emergency]
    public abstract class BaseEmergencyCenter : IEmergencyCenter
    {
        private string name;

        private int amountOfMaximumEmergencies;

        private IList<IEmergency> processedEmergencies; 

        protected BaseEmergencyCenter(string name, int amountOfMaximumEmergencies)
        {
            this.Name = name;
            this.AmountOfMaximumEmergencies = amountOfMaximumEmergencies;
            this.processedEmergencies = new List<IEmergency>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int AmountOfMaximumEmergencies
        {
            get
            {
                return this.amountOfMaximumEmergencies;
            }

            private set
            {
                this.amountOfMaximumEmergencies = value;
            }
        }

        public IList<IEmergency> ProcessedEmergencies => this.processedEmergencies;
        
        public abstract bool IsForRetirement();

        public void AddEmergency(IEmergency emergency)
        {
            if (this.ProcessedEmergencies.Count == this.AmountOfMaximumEmergencies)
            {
                throw new ArgumentOutOfRangeException("Center has reach its maximum amount of processed emergencies, it is ready for retirement.");
            }

            this.processedEmergencies.Add(emergency);
        }
    }
}
