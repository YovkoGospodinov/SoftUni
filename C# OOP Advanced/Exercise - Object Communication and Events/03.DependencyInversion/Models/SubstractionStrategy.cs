namespace _03DependencyInversion
{
    using _03.DependencyInversion.Contracts;

    public class SubstractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}