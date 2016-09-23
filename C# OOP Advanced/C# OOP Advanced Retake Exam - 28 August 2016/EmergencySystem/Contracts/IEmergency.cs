namespace EmergencySystem.Contracts
{
    using EmergencySystem.Enums;
    using Utils;

    public interface IEmergency
    {
        string Description { get; }

        EmergencyLevel EmergencyLevel { get; }

        RegistrationTime RegistrationTime { get; }
    }
}
