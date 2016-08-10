namespace _02.King_sGambit
{
    using System;

    public class RoyalGuard
    {
        private string name;
        private bool isAlive;


        public void OnAttack()
        {
            Console.WriteLine($"RoyalGuard {this.name} is defending!");
        }
    }
}