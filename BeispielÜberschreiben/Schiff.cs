using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielÜberschreiben
{
    internal class Schiff : Fahrzeug
    {
        public Schiff(string kennzeichen) : base(kennzeichen)
        {

        }
        public override void Fahren()
        {
            Console.WriteLine($"Das Schiff {this.kennzeichen} fährt.");
        }
    }
}
