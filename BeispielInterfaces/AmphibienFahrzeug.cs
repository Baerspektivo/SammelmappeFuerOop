using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielInterfaces
{
    internal class AmphibienFahrzeug : IFahren, ISchwimmen
    {
        public void Fahren()
        {
            Console.WriteLine("Das Amphibienfahrzeug fährt.");
        }
        public void Schwimmen()
        {
            Console.WriteLine("Das Amphibienfahrzeug schwimmt.");
        }
    }
}
