namespace _01HarestingFields
{
    using System;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var publicFields = typeof(HarvestingFields).GetFields();

            var privateFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            var allFields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            var input = Console.ReadLine();
            
            while (input != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        foreach (var field in privateFields)
                        {
                            if (field.Attributes.ToString() == "Private")
                            {
                                Console.WriteLine(Print(field));
                            }
                        }
                        break;
                    case "protected":
                        foreach (var field in privateFields)
                        {
                            if (field.Attributes.ToString() == "Family")
                            {
                                Console.WriteLine(Print(field));
                            }
                        }
                        break;

                    case "public":
                        foreach (var field in publicFields)
                        {
                            Console.WriteLine(Print(field));
                        }
                        break;

                    case "all":
                        foreach (var field in allFields)
                        {
                            Console.WriteLine(Print(field));
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            
        }
        public static string Print(FieldInfo field)
        {
            return $"{field.Attributes.ToString().ToLower().Replace("family", "protected")} {field.FieldType.Name} {field.Name}";
        }
    }
}
