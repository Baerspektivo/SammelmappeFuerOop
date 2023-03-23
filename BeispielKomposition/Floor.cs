using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielKomposition
{
    internal class Floor
    {
        private int floorid;

        public Floor(int floorid) 
        { this.floorid = floorid; }
        public int GetFloorid() { return floorid; }
    }
}
