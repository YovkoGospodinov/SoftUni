namespace _11.CatLady
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string cat = Console.ReadLine().Trim();
            List<string> cats = new List<string>();

            while (cat != "End")
            {
                cats.Add(cat);

                cat = Console.ReadLine().Trim();
            }
            string searchedCat = Console.ReadLine().Trim();

            foreach (var el in cats)
            {
                if (el.Contains(" " + searchedCat))
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}
