﻿namespace _02.OldestFamily
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name =name;
            this.age = age;
        }

        public string Name => this.name;
        public int Age => this.age;
    }
}
