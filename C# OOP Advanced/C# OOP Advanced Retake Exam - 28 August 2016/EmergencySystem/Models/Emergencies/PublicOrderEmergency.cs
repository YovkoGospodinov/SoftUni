namespace EmergencySystem.Models.Emergencies
{
    using EmergencySystem.Enums;
    using EmergencySystem.Utils;

    public class PublicOrderEmergency : BaseEmergency
    {
        private EmergencyStatus status;

        public PublicOrderEmergency(string description, EmergencyLevel emergencyLevel, RegistrationTime registrationTime, EmergencyStatus status) : base(description, emergencyLevel, registrationTime)
        {
            this.Status = status;
        }

        public EmergencyStatus Status
        {
            get
            {
                return this.status;
            }

            private set
            {
                this.status = value;
            }
        }
    }
}
