using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielCesaChiffre
{
    internal class CaeserMaschine
    {
        //Um die Werte vom User zu holen (Klartext & Verscheibung)
        private UserEingabe usereingabe = new UserEingabe();
        //Um aus Zahlen Buchstaben zu machen und umgekert
        private Alphabet alphabet = new Alphabet();
        public void Verschlüsseln()
        {
            //Daten vom User holen
            this.usereingabe.SetKlartext();
            this.usereingabe.SetVerscheibung();

            char[] klartextChars = this.usereingabe.GetKlartext().ToCharArray();
            char[] verschlüsselteChars = new char[klartextChars.Length];
            int verschiebung = this.usereingabe.GetVerscheibung();

            for (int i = 0; i < klartextChars.Length; i++)
            {
                int[] klartextInts = new int[klartextChars.Length];
                int[] verschlüsseltInts = new int[klartextChars.Length];
                klartextInts[i] = this.alphabet.PositionImTatsächlichenAlphabetLokalisieren(klartextChars[i]);
                
                verschlüsseltInts[i] = klartextInts[i] + verschiebung;
                verschlüsseltInts[i] = verschlüsseltInts[i] % 52;
                if (verschlüsseltInts[i] == 0)
                {
                    verschlüsseltInts[i] = 52;
                }
                verschlüsselteChars[i] = this.alphabet.GetBuchstabenDerPositionImTatsächlichemAlphabet(verschlüsseltInts[i]);
            }
            string s = new string(verschlüsselteChars);
            Console.WriteLine(s);
        }
    }
}
