namespace _06.CustomEnumAttribute
{
    using System;
    using System.Reflection;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Type type = null;

            if (input == "Rank")
            {
                type = typeof(Rank);

                //var result = typeof(Rank).GetCustomAttributes();

                //foreach (var attribute in result)
                //{
                //    Console.WriteLine(attribute.ToString());
                //}
            }
            else
            {
                type = typeof(Suit);

                //var result = typeof(Suit).GetCustomAttributes();

                //foreach (var attribute in result)
                //{
                //    Console.WriteLine(attribute.ToString());
                //}
            }

            var attributes = type.GetCustomAttributes();

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
            }
        }
    }
}
