using System;

namespace Task3
{
    public interface Items
    {
        string Description { get; }
        decimal GetPrice(Currency currency);
    }
}
