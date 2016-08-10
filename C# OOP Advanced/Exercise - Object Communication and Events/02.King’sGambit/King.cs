using System;

namespace _02.King_sGambit
{
    public class King
    {
        private string name;

        public King(string name)
        {
            this.name = name;
        }

        public void OnAttack()
        {
            Console.WriteLine($"King {this.name} is under attack!");
        }
    }
}