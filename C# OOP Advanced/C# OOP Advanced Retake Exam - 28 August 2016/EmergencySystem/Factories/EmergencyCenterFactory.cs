namespace EmergencySystem.Factories
{
    using EmergencySystem.Contracts;
    using Models.EmergencyCenters;

    public static class EmergencyCenterFactory
    {
        public static IEmergencyCenter RegisterEmergencyCenter(string command)
        {
            string[] centerData = Splitter(command);
            string emergencyCenterName = centerData[1];
            int emergencyCount = int.Parse(centerData[2]);
            IEmergencyCenter currentEmergencyCenter;

            switch (centerData[0])
            {
                case "FireServiceCenter":
                    currentEmergencyCenter = new FiremanServiceCenter(emergencyCenterName, emergencyCount);
                    return currentEmergencyCenter;
                case "MedicalServiceCenter":
                    currentEmergencyCenter = new MedicalServiceCenter(emergencyCenterName, emergencyCount);
                    return currentEmergencyCenter;
                default:
                    currentEmergencyCenter = new PoliceServiceCenter(emergencyCenterName, emergencyCount);
                    return currentEmergencyCenter;
            }
        }

        public static string[] Splitter(string command)
        {
            string[] result = command.Split('|');

            result[0].Replace("Register", string.Empty);

            return result;
        }
    }
}
