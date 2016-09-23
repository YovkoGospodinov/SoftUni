namespace EmergencySystem.Models
{
    using Contracts;
    using EmergencySystem.Enums;
    using EmergencySystem.Utils;

    public abstract class BaseEmergency : IEmergency
    {
        private string description;

        private EmergencyLevel emergencyLevel;

        private RegistrationTime registrationTime;

        protected BaseEmergency(string description, EmergencyLevel emergencyLevel, RegistrationTime registrationTime)
        {
            this.Description = description;
            this.EmergencyLevel = emergencyLevel;
            this.RegistrationTime = registrationTime;
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            private set
            {
                this.description = value;
            }
        }

        public EmergencyLevel EmergencyLevel
        {
            get
            {
                return this.emergencyLevel;
            }

            private set
            {
                this.emergencyLevel = value;
            }
        }

        public RegistrationTime RegistrationTime
        {
            get
            {
                return this.registrationTime;
            }

            private set
            {
                this.registrationTime = value;
            }
        }
    }
}
