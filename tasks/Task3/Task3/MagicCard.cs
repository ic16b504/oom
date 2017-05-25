using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class MagicCard : IMagicCard
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
        #region IMagicCard implementation
        public string Name { get; }
        public string Edition { get; }
        public double Price
        {
            get { return m_price; }
            set { m_price = value; }
        }
        public string Kategorie => Name;
        public string Produkt => Edition;
        public void UpdatePrice(double newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Preis darf nicht negativ sein");
            m_price = newPrice;
        }
        #endregion
    }
}
