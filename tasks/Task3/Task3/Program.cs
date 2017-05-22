using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
