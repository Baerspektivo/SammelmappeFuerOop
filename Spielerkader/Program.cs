using System;
using System.Runtime.CompilerServices;

namespace Spielerkader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] liste = { "Spieler1", "Spieler2", "Spieler3" };
            Spieler spieler = new Spieler(liste[0]);
            spieler.GetInfo();            
        }
        class Spieler
        {
            private string name;
            private int transferGebuer;
            private int marktWert;
            private Random random = new Random();
            //**constructor**
            public Spieler(string name)
            {
                this.name = name;
                MarktWertZufall();
                SetTransferGebuer();
            }
            //**random number**
            public void MarktWertZufall()
            { this.marktWert = random.Next(10000, 1000000); }
            //**playername**
            public string GetName() { return name; }
            //**market value of the players**
            public int GetMarktwert() { return marktWert; }
            //**Transfer fee for sale**
            public void SetTransferGebuer()
            { this.transferGebuer = random.Next(10000, 1000000); }
            public void GetInfo() 
            {
                Console.WriteLine($"{name}, {transferGebuer}, {marktWert}");
            }
        }
    }
}