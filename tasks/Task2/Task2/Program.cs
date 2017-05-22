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
            var a = new Auto("Aston Martin", "Schwarz", 200000);
            var b = new Auto("Ford", "Weiß", 30500);
            var c = new Auto("VW", "Blau", 45000);

            Console.WriteLine();
            Console.WriteLine(a.Type, a.Colour, a.GetPrice());
            Console.WriteLine(b.Type, b.Colour, b.GetPrice());
            Console.WriteLine(c.Type, c.Colour, c.GetPrice());
        }
    }
}
