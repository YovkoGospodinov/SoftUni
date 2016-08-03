using System.Collections.Generic;

namespace _08.MilitaryElite.Contracts
{
    public interface IEngineer
    {
        IList<Repair> Repairs { get; }
    }
}