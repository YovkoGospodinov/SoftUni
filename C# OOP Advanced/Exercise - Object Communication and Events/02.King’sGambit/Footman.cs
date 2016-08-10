namespace _02.King_sGambit
{
    using System;

    public class Footman
    {
        private string name;


        public void OnAttack()
        {
            Console.WriteLine($"Footman {this.name} is panicking!");
        }
    }
}