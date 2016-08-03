namespace _08.MilitaryElite.Contracts
{
    public interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }

        string ToString();
    }
}