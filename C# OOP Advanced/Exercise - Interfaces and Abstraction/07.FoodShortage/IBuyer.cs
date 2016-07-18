using System.Security.Cryptography.X509Certificates;

namespace _07.FoodShortage
{
    public interface IBuyer
    {
        int Food { get; }

        void BuyFood();
    }
}