using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielKomposition
{
    internal class Building
    {
        private string name;
        private Floor[] floors;

        public Building(string name, int floors)
        {
            this.name = name;
            this.floors = new Floor[floors];
            for (int i = 0; i < this.floors.Length; i++)
            {
                this.floors[i] = new Floor(i);
            }
        }
        public void PrintInfos()
        {
            Console.WriteLine($"Gebäude {name}:");
            foreach  (Floor floor in floors)
            {
                Console.WriteLine("Etage " + floor.GetFloorid());
            }
        }
    }
}
