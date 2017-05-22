using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Task4
{
    class Serialization
    {

        public static void Run(Items[] itmes)
        {
            var auto = itmes[0];

            File.WriteAllText(@"c:\itmes.json", JsonConvert.SerializeObject(auto));

            using (StreamWriter file = File.CreateText(@"c:\itmes.json"))
            {
                JsonSerializer serial = new JsonSerializer();
                serial.Serialize(file, auto);
            }
        }
    }
}
