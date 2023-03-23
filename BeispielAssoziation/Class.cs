using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielAssoziation
{
    internal class Class
    {
        private Room room;
        private string name;

        public Class(string name)
        {
            this.name = name;
        }
        public string GetName() { return name; }
        public void SetRoom(Room room)
        { 
            this.room = room;
            this.room.SetClass(this);
        }
        public void PrintInfos()
        {
            Console.WriteLine($"Diese Klasse ist im Raum {room.Get_Name()}.");
        }
    }
}
