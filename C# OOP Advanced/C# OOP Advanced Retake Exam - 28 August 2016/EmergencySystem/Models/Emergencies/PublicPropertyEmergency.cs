namespace EmergencySystem.Models.Emergencies
{
    using EmergencySystem.Enums;
    using EmergencySystem.Utils;

    public class PublicPropertyEmergency : BaseEmergency
    {
        private int propertyDamage;

        public PublicPropertyEmergency(string description, EmergencyLevel emergencyLevel, RegistrationTime registrationTime, int propertyDamage) : base(description, emergencyLevel, registrationTime)
        {
            this.PropertyDamage = propertyDamage;
        }

        public int PropertyDamage
        {
            get
            {
                return this.propertyDamage;
            }

            private set
            {
                this.propertyDamage = value;
            }
        }
    }
}
