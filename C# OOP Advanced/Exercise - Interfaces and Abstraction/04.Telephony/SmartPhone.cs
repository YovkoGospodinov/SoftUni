

namespace _04.Telephony
{
    using System;
    using System.Text;

    public class SmartPhone : IBrowsable, ICallable
    {
        private string websites;
        private string phoneCalls;

        public string BrowseWWW(params string[] websites)
        {
            StringBuilder webs = new StringBuilder();

            foreach (var website in websites)
            {
                bool isValid = true;
                foreach (var symbol in website)
                {
                    if (char.IsDigit(symbol))
                    {
                        webs.AppendLine(string.Format($"Invalid URL!"));
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    webs.AppendLine(string.Format($"Browsing: {website}!"));
                }
            }

            return webs.ToString();
        }

        public string CallPhone(params string[] phoneCalls)
        {
            StringBuilder calls = new StringBuilder();

            foreach (var number in phoneCalls)
            {
                bool isValid = true;
                foreach (var digit in number)
                {
                    if (!char.IsDigit(digit))
                    {
                        calls.AppendLine(String.Format($"Invalid number!"));
                        isValid = false;
                        break;
                    }

                }
                if (isValid)
                {
                    calls.AppendLine(string.Format($"Calling... {number}"));
                }
            }

            return calls.ToString();
        }

        public override string ToString()
        {
            return this.CallPhone() + this.BrowseWWW();
        }
    }
}