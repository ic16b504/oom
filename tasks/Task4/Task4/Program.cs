
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var magiccard = new IMagic[]
            {
                new MagicCard("Garruk Wildspeaker" ,"Lorwyn" ,8.5),
                new MagicCard("Loxodon Warhammer" ,"Mirrodin" ,1.00),
                new MagicCard("Knight Exemplar" ,"2011 Core Set" ,4.00),

                new MagicProdukte("Display", "Return to Ravnica Boosterdisplay" ,119.99),
                new MagicProdukte("Deck", "Amonkhet Planeswalker Deck" ,11.99),
            };

            foreach (var mc in magiccard)
            {
                Console.WriteLine("");
                Console.WriteLine($"{mc.Name}, {mc.Edition}, {mc.Price} Euro");
                Console.ReadKey();
            }

            Serialization.Run(magiccard);
            Console.ReadKey();
        }
    }
}
