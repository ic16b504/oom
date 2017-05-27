
using System;
using Newtonsoft.Json;

namespace Task4
{
    class MagicProdukte : IMagic
    {
        private double m_price;
        private int magic;

        [JsonConstructor]
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

        #region IMagic implementation
        public string Kategorie { get; }
        public string Produkt { get; }
        public double Price
        {
            get { return m_price; }
            set { m_price = value; }
        }
        [JsonIgnore]
        public string Name => Kategorie;
        [JsonIgnore]
        public string Edition => Produkt;
        public void UpdatePrice(double newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Preis darf nicht negativ sein");
            m_price = newPrice;
        }
        #endregion
    }
}
