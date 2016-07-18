namespace _04.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] calls = Console.ReadLine().Split(' ');
            string[] websites = Console.ReadLine().Split(' ');

            var phone = new SmartPhone();

            Console.Write(phone.CallPhone(calls));
            Console.WriteLine(phone.BrowseWWW(websites));
        }
    }
}
