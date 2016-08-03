namespace _08.MilitaryElite.Contracts
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral
    {
        IList<Private> Privates { get; }
    }
}