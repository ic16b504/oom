using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            var items = new Items[]
            {
                    new Auto("Aston Martin", "", 400, Currency.EUR),
                    new Auto("Ford", "", 200, Currency.EUR),
                    new Auto("VW", "", 300, Currency.EUR),
            };

            var currency = Currency.EUR;
            foreach (var i in items)
            {
                Console.WriteLine($"{i.Description} {i.GetPrice(currency)} {currency}");
            }
            Serialization.Run(items);
        }
    }
}
