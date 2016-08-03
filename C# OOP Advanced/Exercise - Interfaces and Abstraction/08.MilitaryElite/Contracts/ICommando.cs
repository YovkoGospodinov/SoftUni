namespace _08.MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ICommando
    {
        IList<Mission> Missions { get; }
    }
}