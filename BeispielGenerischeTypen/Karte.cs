using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielGenerischeTypen
{

    public class Karte : IKarte
    {
        public string Farbe { get; }
        public string Wert { get; }

        public Karte(string farbe, string wert)
        {
            Farbe = farbe;
            Wert = wert;
        }
    }

}
