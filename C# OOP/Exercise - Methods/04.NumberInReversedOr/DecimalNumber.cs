namespace _04.NumberInReversedOr
{
    public class DecimalNumber
    {
        private decimal number;

        public DecimalNumber(decimal number)
        {
            this.number = number;
        }

        public decimal Number => this.number;

        public string ReverseDigits()
        {
            string result = string.Empty;

            string numberAsString = this.number.ToString();

            foreach (char digit in numberAsString)
            {
                result = digit + result;
            }

            return result;
        }
    }
}
