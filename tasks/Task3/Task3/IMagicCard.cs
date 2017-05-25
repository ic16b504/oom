using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IMagicCard
    {
        string Name { get; }
        string Edition { get; }
        double Price { get; set; }

        string Kategorie { get; }
        string Produkt { get; }

        void UpdatePrice(double newPrice);
    }
}
