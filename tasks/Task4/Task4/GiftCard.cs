using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task4
{
    class GiftCard : Items
    {
        [JsonConstructor]
        public GiftCard(decimal a, Currency currency)
        {
            if (a <= 0) throw new ArgumentException("a must be greater than 0.", nameof(a));

            A = a;
            Currency = currency;
        }

        public decimal A { get; }
        public Currency Currency { get; }

        [JsonIgnore]
        public string Description => "GiftCard";

        public decimal GetPrice(Currency currency)
        {
            if (currency == Currency) return A;
            return A;
        }
    }
}
