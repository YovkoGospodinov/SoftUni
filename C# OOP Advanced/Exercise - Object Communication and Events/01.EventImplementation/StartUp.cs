namespace _01.EventImplementation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var dispatcher = new Dispather();
            var handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string name = Console.ReadLine();

            while (name != "End")
            {
                dispatcher.Name = name;

                name = Console.ReadLine();
            }
        }
    }
}
