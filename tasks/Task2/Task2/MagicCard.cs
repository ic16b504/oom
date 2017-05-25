using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MagicCard
    {
        private double m_price;

        public MagicCard(string name, string edition, double price)
        {
            if (name == null || name.Length == 0) throw new ArgumentException("Name fehlt");
            if (edition == null || edition.Length == 0) throw new ArgumentException("Edition fehlt");
            if (price < 0) throw new ArgumentException("Preis darf nicht negativ sein");

            Name = name;
            Edition = edition;
            Price = price;
        }

        public string Name { get; }
        public string Edition { get; }
        public double Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public void UpdatePrice(double newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Preis darf nicht negativ sein", nameof(newPrice));
            m_price = newPrice;
        }
    }
}
