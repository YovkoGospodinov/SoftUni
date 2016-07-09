namespace _06.PrimeChecker
{
    using System;

    public class Number
    {
        public int number;
        public bool isPrime;

        public Number(int number, bool isPrime)
        {
            this.number = number;
            this.isPrime = isPrime;

            this.isPrime = CheckIfPrime(number);
        }

        private bool CheckIfPrime(int num)
        {
            bool prime = true;

            for (int i = 2; i < Math.Sqrt(num) + 1; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }

        public Number GetNextPrime()
        {
            int nextPrimeNum = this.number + 1;

            while (!CheckIfPrime(nextPrimeNum))
            {
                nextPrimeNum++;
            }

            return new Number(nextPrimeNum, true);
        }
    }
}
