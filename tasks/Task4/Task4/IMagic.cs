


namespace Task4
{
    interface IMagic
    {
        string Name { get; }
        string Edition { get; }
        double Price { get; set; }

        string Kategorie { get; }
        string Produkt { get; }

        void UpdatePrice(double newPrice);
    }
}
