﻿using System.Collections.Generic;

namespace _08.MilitaryElite.Contracts
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }
    }
}