using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MagicProdukte : IMagicCard
    {
        private double m_price;
        private int magic;

        public MagicProdukte(string kategorie, string produkt, double price)
        {
            if (kategorie == null || kategorie.Length == 0) throw new ArgumentException("Kategorie fehlt");
            if (produkt == null || produkt.Length == 0) throw new ArgumentException("Produkt fehlt");
            if (price < 0) throw new ArgumentException("Preis darf nicht negativ sein");

            Kategorie = kategorie;
            Produkt = produkt;
            Price = price;
        }

        public MagicProdukte(string kategorie, string produkt, double price, int magic) : this(kategorie, produkt, price)
        {
            this.magic = magic;
        }
        #region IMagicCard implementation
        public string Kategorie { get; }
        public string Produkt { get; }
        public double Price
        {
            get { return m_price; }
            set { m_price = value; }
        }
        public string Name => Kategorie;
        public string Edition => Produkt;

        public void UpdatePrice(double newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Preis darf nicht negativ sein");
            m_price = newPrice;
        }
        #endregion
    }
}
