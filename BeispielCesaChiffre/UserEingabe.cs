using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielCesaChiffre
{
    public class UserEingabe
    {
        private int verschiebung;
        private string? klartext;

        public void SetVerscheibung()
        {
            Console.WriteLine("Um wievile Positionen soll das Alphabet verschoben werden?");
            string? eingabe = Console.ReadLine();
            this.verschiebung = Convert.ToInt32(eingabe);
        }
        public void SetKlartext()
        {
            Console.WriteLine("Welchen text wollen Sie verschlüsseln?");
            string? eingabe = Console.ReadLine();
            this.klartext = eingabe;
        }
        public int GetVerscheibung()
        {
            return this.verschiebung;
        }
        public string? GetKlartext()
        {
            return this.klartext;
        }
    }
}
