namespace EmergencySystem.Models.Emergencies
{
    using EmergencySystem.Enums;
    using EmergencySystem.Utils;

    public class PublicHealthEmergency : BaseEmergency
    {
        private int casualties;

        public PublicHealthEmergency(string description, EmergencyLevel emergencyLevel, RegistrationTime registrationTime, int casualties) : base(description, emergencyLevel, registrationTime)
        {
            this.Casualties = casualties;
        }

        public int Casualties
        {
            get
            {
                return this.casualties;
            }

            private set
            {
                this.casualties = value;
            }
        }
    }
}
