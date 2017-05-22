using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Globalization;


namespace Task3
{
    class Program
    {
        public enum Currency
        {
            EUR,
            USD,
            GBP,
            CHF,
            JPY
        }
        public class GiftCard : IItem
        {
            public GiftCard(decimal amount, Currency currency)
            {
                if (amount <= 0) throw new ArgumentException("Amount must be greater than 0.", nameof(amount));

                Amount = amount;
                //Currency = currency;
                Code = Guid.NewGuid().ToString();
                IsRedeemed = false;
            }
            public decimal Amount { get; }
            //public Currency Currency { get; }
            public string Code { get; }

            public void Redeem()
            {
                if (IsRedeemed) throw new InvalidOperationException($"Gift card {Code} has already been redeemed.");
                IsRedeemed = true;
            }
            public bool IsRedeemed { get; private set; }

            #region IItem implementation

            public decimal GetPrice(Currency currency)
            {
                //if (currency == Currency) return Amount;
                //var url = string.Format(@"http://download.finance.yahoo.com/d/quotes.csv?s={0}=X&f=sl1d1t1c1ohgv&e=.csv", key);
                //var data = new WebClient().DownloadString(url);
                var parts = data.Split(',');
                var rate = decimal.Parse(parts[1], CultureInfo.InvariantCulture);

                return Amount * rate;
            }

            public string Description => "GiftCard " + Code;

            #endregion
        }
        public interface IItem
        {
            
            string Description { get; }
            //decimal GetPrice(Currency currency);
        }

        static void Main(string[] args)
        {
            var items = new IItem[]
            {
                new Book("Real-Time Rendering", "978-1568814247", 78.95m, Currency.EUR),
                new Book("The Hitchhiker's Guide to the Galaxy", "978-0345391803", 6.60m, Currency.EUR),
                new Book("C# 6.0 in a Nutshell", "978-1491927069", 44.95m, Currency.EUR),
                new Book("Trillions: Thriving in the Emerging Information Ecology", "978-1118176078", 35.24m, Currency.EUR),
                new Book("Cryptonomicon", "978-0060512804", 7.70m, Currency.EUR),
                new GiftCard(50, Currency.EUR),
                new GiftCard(10, Currency.EUR),
                new GiftCard(100, Currency.EUR),
            };

            var currency = Currency.EUR;
            foreach (var x in items)
            {
                Console.WriteLine($"{x.Description.Truncate(50),-50} {x.GetPrice(currency),8:0.00} {currency}");
            }
        }
    }
    }
}
