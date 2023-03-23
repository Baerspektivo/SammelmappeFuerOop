using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielAssoziation
{
    internal class Room
    {
        private Class _class;
        private string _name;

        public Room(string name)
        {
            this._name = name;
        }
        public string Get_Name() { return _name; }
        public void SetClass(Class _class)
        {
            this._class = _class;
        }
        public void PrintInfos()
        {
            Console.WriteLine($"In diesem Raum ist die Klasse {_class.GetName()}.");
        }
    }
}
