using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MagicCard("Garruk Wildspeaker", "Lorwyn", 8.50);
            var b = new MagicCard("Loxodon Warhammer", "Mirrodin", 1.00);
            var c = new MagicCard("Knight Exemplar", "2011 Core Set", 4.00);

            Console.WriteLine("Magic Cards:");
            Console.WriteLine($"{a.Name}, Edition: {a.Edition}, Preis: {a.Price} Euro");
            Console.WriteLine($"{b.Name}, Edition: {b.Edition}, Preis: {b.Price} Euro");
            Console.WriteLine($"{c.Name}, Edition: {c.Edition}, Preis: {c.Price} Euro");
            Console.ReadKey();
        }
    }
}
