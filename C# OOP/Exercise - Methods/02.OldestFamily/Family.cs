namespace _02.OldestFamily
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            //Person oldestPerson = members.Aggregate((p1, p2) => p1.Age > p2.Age ? p1 : p2);
            //Person oldestPerson = members.OrderByDescending(p => p.Age).First();
            var maxAge = members.Max(p => p.Age);
            Person oldestPerson = members.First(p => p.Age == maxAge);
            return oldestPerson;
        }
    }
}
