namespace _03.LastDigitName
{
    public class Number
    {
        private int givenNumber;

        public Number(int number)
        {
            this.givenNumber = number;
        }

        public int GivenNumber => this.givenNumber;

        public string LastDigitAsWord()
        {
            string word = string.Empty;

            int lastDigit = this.givenNumber % 10;

            switch (lastDigit)
            {
                case 0:
                    word = "zero";
                    break;
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
                default:
                    word = "Please enter valid integer number";
                    break;
            }

            return word;
        }
    }
}
