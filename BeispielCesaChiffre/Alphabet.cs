using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BeispielCesaChiffre
{
    public class Alphabet
    {
        //Ein Array welches das Alphabet in Großbuchstaben darstellt
        //Jeder Grp0buchstabe hat eine Indexnummer
        //Position eines Großbuchstabens im tatsächlichen Alphabet ist Indexnummer +1
        private char[] alphabet = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        /// <summary>
        /// Gibt die Position eines Großgeschreibenen Buchstanbens (ASCII) im tatsächlichen Alphabet zurück
        /// </summary>
        /// <param name="x">Großgeschreibener Character</param>
        /// <returns>Position im Alphabet</returns>
        public int PositionImTatsächlichenAlphabetLokalisieren(char x)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (x == alphabet[i])
                {
                    return i + 1;
                }
            }
            return 0;
        }
        public char GetBuchstabenDerPositionImTatsächlichemAlphabet(int x)
        {
            if (x == 0)
            {
                return this.alphabet[x];
            }
            return this.alphabet[x - 1];
        }
    }
}
