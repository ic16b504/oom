using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Auto
    {
        private decimal a_price;

        public string Typ { get; }
        public string Colour { get; }
      
        public Auto(string typ, string colour, decimal price)
        {
            if (string.IsNullOrWhiteSpace(typ)) throw new ArgumentException("Typ darf nicht leer sein.", nameof(typ));
            if (string.IsNullOrWhiteSpace(colour)) throw new ArgumentException("Colour darf nicht leer sein.", nameof(colour));

            Typ = typ;
            Colour = colour;
            UpdatePrice(price);
        }

        public void UpdatePrice(decimal newprice)
        {
            if (newprice < 0) throw new ArgumentException("Der Preis darf nicht negativ sein.", nameof(newprice));
            a_price = newprice;
        }

        static void Main(string[] args)
        {
            Auto auto = new Auto("Ford Shelby GT500", "Weiß", 100000);
            auto.a_price = -100000;

            Console.WriteLine($"Auto Preis:"+auto.a_price);
        }
    }
}
