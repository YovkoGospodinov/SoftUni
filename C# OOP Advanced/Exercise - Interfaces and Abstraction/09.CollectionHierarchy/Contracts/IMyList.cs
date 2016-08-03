namespace _09.CollectionHierarchy.Contracts
{
    public interface IMyList : IAddable, IRemovable
    {
        int Used { get; }
    }
}