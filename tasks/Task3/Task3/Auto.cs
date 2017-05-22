﻿using System;

namespace Task3
{
    public class Auto : Items
    {
        private decimal a_price;

        public Auto(string type, string colour, decimal price, Currency currency)
        {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("Type must not be empty.", nameof(type));
            if (string.IsNullOrWhiteSpace(colour)) throw new ArgumentException("Type must not be empty.", nameof(type));

            Type = type;
            Colour = colour;
            UpdatePrice(price, currency);
        }

        public string Type { get; }
        public string Colour { get; }
        public Currency Currency { get; private set; }

        public decimal Price => a_price;

        public string Description => Type;

        public void UpdatePrice(decimal newPrice, Currency currency)
        {
            if (newPrice < 0) throw new ArgumentException("Price must not be negative.", nameof(newPrice));
            a_price = newPrice;
            Currency = currency;
        }

        public decimal GetPrice(Currency currency)
        {
            if (currency == Currency) return a_price;
            return a_price;
        }
    }
}
