using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public interface Items
    {
        string Description { get; }
        decimal GetPrice(Currency currency);
    }
}
