using System.Threading.Channels;

namespace BeispielCesaChiffre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Wolrd");
            //Beispiel Ceasar-Verschlüsselung
            //Klartext Alphabet: ABDCEFGHIJKLMNOPQRSTUVFXYZ
            //Um wieviel Stellen word verrückt: 3
            //Verschlüsseltes Alphabet: DEFGHIJKLMNOPQRSTUVWXYZABC
            //A B D C E F G H I J K L M N O P Q R S T U V W X Y Z
            //D E F G H I J K L M N O P Q R S T U V W X Y Z A B C

            //Klartext:         HALLOWELT
            //Verschlüsselt:    KDOORZHOW
            //Klartext:         HALLOWELT

            //klartext:         Fisch
            //Verschlüsselt:    ILVGK
            //Klartext:         FISCH

            //Klartext:         Computer
            //Verschlüsselt:    GRPSXWHU
            //Klartext:         COMPUTER

            CaeserMaschine caeserMaschine = new CaeserMaschine();
            caeserMaschine.Verschlüsseln();
        }
    }
}