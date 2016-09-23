namespace EmergencySystem.Contracts
{
    using System.Collections.Generic;

    public interface IEmergencyCenter
    {
        string Name { get; }

        int AmountOfMaximumEmergencies { get; }

        IList<IEmergency> ProcessedEmergencies { get; }

        bool IsForRetirement();

        void AddEmergency(IEmergency emergency);
    }
}
