
using System;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{
    class Serialization
    {
        public static void Run(IMagic[] magic)
        {
            var m = magic[0];

            Console.WriteLine(JsonConvert.SerializeObject(m));

            var sm = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(magic, sm));
            var mt = JsonConvert.SerializeObject(magic, sm);

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var file = Path.Combine(desktop, "magic.json");
            File.WriteAllText(file, mt);

            var magicfile = File.ReadAllText(file);
            var imagicfile = JsonConvert.DeserializeObject<IMagic[]>(magicfile, sm);
            foreach (var mm in imagicfile) Console.WriteLine($"{mm.Name}, {mm.Edition}, {mm.Price} Euro");
        }
    }
}
