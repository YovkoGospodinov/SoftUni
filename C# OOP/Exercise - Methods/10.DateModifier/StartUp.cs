namespace _10.DateModifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();


            //DateTime firstDate = DateTime.ParseExact(firstInput, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime firstDate = ConvertToDateTime(firstInput);
            //DateTime secondDate = DateTime.ParseExact(secondInput, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime secondDate = ConvertToDateTime(secondInput);

            

            if (firstDate.CompareTo(secondDate) < 0)
            {
                TimeSpan difference = secondDate - firstDate;
                Console.WriteLine(difference.Days);
            }
            else
            {
                TimeSpan difference = firstDate - secondDate;
                Console.WriteLine(difference.Days);
            }
        }
        public static DateTime ConvertToDateTime(string input)
        {
            var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var date = new DateTime(int.Parse(tokens[0]), int.Parse(tokens[1]), int.Parse(tokens[2]));

            return date;
        }
    }
}
