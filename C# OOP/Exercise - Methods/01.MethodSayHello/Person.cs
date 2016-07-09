namespace _01.MethodSayHello
{
    public class Person
    {
        public string name;

        public Person(string name)
        {
            this.name = name;
        }

        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        this.name = value;
        //    }
        //}

        public string Greeting()
        {
            return $"{this.name} says \"Hello\"!";
        }
    }
}
