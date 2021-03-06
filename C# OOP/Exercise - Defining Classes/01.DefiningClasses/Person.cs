﻿namespace _01.DefiningClasses
{
    public class Person
    {
        //the fields are set public for the need of the task
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(int age,string name) : this(age)
        {
            this.Name = name;
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}
