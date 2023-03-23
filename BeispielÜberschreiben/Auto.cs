using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielÜberschreiben
{
    internal class Auto :Fahrzeug
    {
        public Auto(string kennzeichen) : base(kennzeichen)
        {

        }
        public override void Fahren()
        {
            Console.WriteLine($"Das Auto {this.kennzeichen} fährt.");
        }

    }
}
