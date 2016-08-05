namespace _04.Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers =
                Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            var lake = new Lake(numbers);

            var result = new StringBuilder();

            foreach (var number in lake)
            {
                result.Append(number + ", ");
            }

            Console.WriteLine(result.ToString().Trim().TrimEnd(','));
        }
    }
}
