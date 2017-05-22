using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace Task2
{
    public class Auto
    {
        private decimal a_price;

        public Auto(string type, string colour, decimal price)
        {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("Type must not be empty.", nameof(type));
            if (string.IsNullOrWhiteSpace(colour)) throw new ArgumentException("Type must not be empty.", nameof(type));

            Type = type;
            Colour = colour;
            UpdatePrice(price);
        }

        public string Type { get; }
        public string Colour { get; }

        public decimal GetPrice()
        {
            return a_price;
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0) throw new ArgumentException("Price must not be negative.", nameof(newPrice));
            a_price = newPrice;
        }
    }
}
