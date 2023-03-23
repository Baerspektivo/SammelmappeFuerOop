namespace BeispielStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("Fiat", "500");
            Auto a2 = new Auto("Ford", "Fiesta");
            int anzahl = Auto.GetAnzahl();
            Console.WriteLine(anzahl);

            Console.WriteLine(a1.GetAnzahl2());
            Console.WriteLine(a2.GetAnzahl2());
        }
        class Auto
        {
            private string marke;
            private string modell;

            private static int anzahl;
            public Auto(string marke, string modell)
            {
                this.marke = marke;
                this.modell = modell;
                anzahl = anzahl + 1;
            }
            public static int GetAnzahl() { return anzahl; }
            public int GetAnzahl2() { return anzahl; }
        }
    }
}