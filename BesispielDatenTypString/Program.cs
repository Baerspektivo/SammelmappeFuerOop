namespace BesispielDatenTypString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Was ist ein String

                => die repräsentation einer sequentiellen Auflistung von chars,
                ein char = 1 UTF-16-Zeichen

                Die maximale Größe eines Strings ist ca. 2GB (1 Milliarde Zeichen)

                immutable => nicht veränderbar
                wenn Sie einen string verändern, dann erschaffen Sie in Wahrheit einen neuen,
                und der alte bleibt im Speicher vorhanden.
                
                Wie können Strings erzeugt werden?
                literal
             */
            string myString = "Hello World";
            // Kostruktor
            string myString2 = new string('*', 10);
            Console.WriteLine(myString2);
            // durch char-arrays
            char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
            string myString3 = new string(charArray);
            // was kann mir die Klasse String erzählen?
            // die länge
            int x = myString.Length;
            // die einzelnen Chars
            char meinE = myString3[1];
            Console.WriteLine(meinE);
            /////////////////////////////////////////////////////////////////////////////////////////
            // Vergleichen von Strings
            Console.WriteLine(myString3.Equals("Hello"));
            Console.WriteLine(myString3.Equals("Hella"));
            // Womit der String beginnt
            myString3.StartsWith('H');
            myString3.StartsWith("Hell");
            // Womit der String endet
            myString3.EndsWith('o');
            myString3.EndsWith("lo");
            // Wo eine Zeichenkette beginnt
            string myString4 = "Ein Ring Sie alle zu knechten, ins Dunkel zu treiben und ewig zu binden";
            Console.WriteLine(myString4.IndexOf("Ring"));           // erster Treffer
            Console.WriteLine(myString4.LastIndexOf("Ring"));       // letzter Treffer
            Console.WriteLine(myString4.Substring(4));
           
            Console.WriteLine(myString4.CompareTo(
                "Fin Ring Sie alle zu knechten, " +
                "ins Dunkel zu Treiben und ewig zu Ring Binden"));
            Console.WriteLine(myString4.CompareTo(
                "Ain Ring Sie alle zu knechten, " +
                "ins Dunkel zu Treiben und ewig zu Ring binden"));
            Console.WriteLine(myString4.CompareTo(
                "Ein Ring Sie alle zu knechten, " +
                "ins Dunkel zu Treiben und ewig zu Ring binden"));
            /////////////////////////////////////////////////////////////////////////////////////////
            // Kombinieren
            myString4.Substring(myString4.IndexOf("Ring"));
            // CompareTo
            // Werte werden Index für Index verglichen, keine unterschiede = 0
            // WertA == WertB = 0
            // WertA > WertB = 1
            // WertA < WertB = -1
            /////////////////////////////////////////////////////////////////////////////////////////
            //Strings manipulieren
            //Trim
            string myString5 = "****Hallo*****";
            Console.WriteLine(myString5.Trim('*')); //=> Hello World
            Console.WriteLine(myString5.Trim('*'));
            //TrimStart || TrimEnd => Trim macht beides

            //PadLeft || PadRight
            string myString6 = "Stuhl";
            Console.WriteLine(myString6.PadLeft(myString6.Length + 2, '*'));
            Console.WriteLine(myString6.PadLeft(myString6.Length + 2));
            Console.WriteLine(myString6.PadRight(myString6.Length + 2, '*'));
            Console.WriteLine(myString6.PadRight(myString6.Length + 2));

            //Insert
            string mystring7 = "Ich habe meinen verloren";
            mystring7 = mystring7.Insert(16, "Schlüssel ");
            Console.WriteLine(mystring7);
            //Remove
            mystring7 = mystring7.Remove(26);
            Console.WriteLine(mystring7);
            mystring7 = mystring7.Remove(0, 16);
            Console.WriteLine(mystring7);
        }
    }
}

    
