namespace TheSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            List<HardwareComponent> hardware = new List<HardwareComponent>();

            string input = Console.ReadLine();

            while (input != "System Split")
            {
                string[] command = input.Split('(');

                if (command[0] == "RegisterPowerHardware")
                {
                    string[] hardwareDetails = command[1].Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                    string hardwareName = hardwareDetails[0];
                    int hardwareCapacity = int.Parse(hardwareDetails[1]);
                    int hardwareMemory = int.Parse(hardwareDetails[2].Substring(0, hardwareDetails[2].Length - 1));
                    
                    HardwareComponent currentHardware = new PowerHardware(hardwareName, hardwareCapacity, hardwareMemory);

                    hardware.Add(currentHardware);
                }
                else if (command[0] == "RegisterHeavyHardware")
                {
                    string[] hardwareDetails = command[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string hardwareName = hardwareDetails[0];
                    int hardwareCapacity = int.Parse(hardwareDetails[1]);
                    int hardwareMemory = int.Parse(hardwareDetails[2].Substring(0, hardwareDetails[2].Length - 1));

                    HardwareComponent currentHardware = new HeavyHardware(hardwareName, hardwareCapacity, hardwareMemory);

                    hardware.Add(currentHardware);
                }
                else if (command[0] == "RegisterLightSoftware")
                {
                    string[] softwareDetails = command[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string hardwareComponentName = softwareDetails[0];
                    string softwareName = softwareDetails[1];
                    int softwareCapacity = int.Parse(softwareDetails[2]);
                    int softwareMemory = int.Parse(softwareDetails[3].Substring(0, softwareDetails[3].Length - 1));

                    SoftwareComponent currentSoftware = new LightSoftware(softwareName, softwareCapacity, softwareMemory, hardwareComponentName);

                    //check if the hardware name exist in the collection of existing hardware components
                    if (isHardwareCompExist(hardware, currentSoftware))
                    {
                        //needed hardware component
                        var neededHardware = hardware.Find(x => x.Name == hardwareComponentName);

                        //check if the hardware have enough resources
                        if (HardwareComponent.haveEnoughMemCap(neededHardware, currentSoftware))
                        {
                            neededHardware.AddSoftware(currentSoftware);
                        }
                    }
                }
                else if (command[0] == "RegisterExpressSoftware")
                {
                    string[] softwareDetails = command[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    string hardwareComponentName = softwareDetails[0];
                    string softwareName = softwareDetails[1];
                    int softwareCapacity = int.Parse(softwareDetails[2]);
                    int softwareMemory = int.Parse(softwareDetails[3].Substring(0, softwareDetails[3].Length - 1));

                    SoftwareComponent currentSoftware = new ExpressSoftware(softwareName, softwareCapacity, softwareMemory, hardwareComponentName);

                    //check if the hardware name exist in the collection of existing hardware components
                    if (isHardwareCompExist(hardware, currentSoftware))
                    {
                        //needed hardware component
                        var neededHardware = hardware.Find(x => x.Name == hardwareComponentName);

                        //check if the hardware have enough resources
                        if (HardwareComponent.haveEnoughMemCap(neededHardware, currentSoftware))
                        {
                            neededHardware.AddSoftware(currentSoftware);
                        }
                    }
                }
                else if (command[0] == "ReleaseSoftwareComponent")
                {
                    string[] commandDetails = command[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    string hardwareName = commandDetails[0];
                    string softwareName = commandDetails[1].Substring(0, commandDetails[1].Length - 1);
                    //check if the hardware exist
                    var hardwareItem = hardware.FirstOrDefault(x => x.Name == hardwareName);
                    if (hardwareItem != null)
                    {
                        //check if the software exist
                        var tempItem = hardware.First(x => x.Name == hardwareName);
                        var softItem = tempItem.Software.FirstOrDefault(x => x.Name == softwareName);
                        if (softItem != null)
                        {
                            hardwareItem.RemoveSoftware(softItem);
                        }
                    }

                }

                else if (command[0] == "Analyze")
                {
                    Console.WriteLine(SystemAnalyze(hardware));
                }
                else if (command[0] == "System Split")
                {
                    
                }

                input = Console.ReadLine();
            }

            //if (firstH.Software.Contains(firstSoft))
            //{
            //    firstH.RemoveSoftware(firstSoft);
            //}

            //Console.WriteLine();

            Console.WriteLine(SystemAnalyze(hardware));

        }
        //TODO
        //Move methods-command to static class

        #region Methods
//Check if name of the given hardware component exist when adding a new software component.
        public static bool isHardwareCompExist(List<HardwareComponent> existingHardware,
            SoftwareComponent currentSoftware)
        {
            bool result = true;

            var item = existingHardware.FirstOrDefault(x => x.Name == currentSoftware.HardwareComponentName);
            if (item == null)
            {
                result = false;
            }
            return result;
        }

        //Execute Analyze command
        public static string SystemAnalyze(List<HardwareComponent> hardware)
        {
            StringBuilder systemData = new StringBuilder();

            int hardwareComponents = hardware.Count;
            int softwareComponents = 0; //var softcomp = hardware.Sum(x => x.Software.Count);
            int totalMemory = 0;
            int usedMemomry = 0;
            int totalCapacity = 0;
            int usedCapacity = 0;


            foreach (var currentHardware in hardware)
            {
                softwareComponents += currentHardware.Software.Count;
                totalMemory += currentHardware.MaxMemory;
                usedMemomry += currentHardware.UsedMemory;
                totalCapacity += currentHardware.MaxCapacity;
                usedCapacity += currentHardware.UsedCapacity;
            }

            systemData.AppendLine("System Analysis");
            systemData.AppendLine(string.Format($"Hardware Components: {hardwareComponents}"));
            systemData.AppendLine(string.Format($"Software Components: {softwareComponents}"));
            systemData.AppendLine(string.Format($"Total Operational Memory: {usedMemomry} / {totalMemory}"));
            systemData.AppendLine(string.Format($"Total Capacity Taken: {usedCapacity} / {totalCapacity}"));

            return systemData.ToString();
        }

        #endregion
    }
}
