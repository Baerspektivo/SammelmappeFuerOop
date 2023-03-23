namespace BeispielVererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KFZ k1 = new KFZ();
            k1.RestwertBerechnen();         //Methode aus KFZ
            k1.Auszahlen();                 //Methode aus Versicherungsobjekt

            Immobilie i1 = new Immobilie();
            i1.RestwertBerechnen();         //Methode aus Immobilie
            i1.Auszahlen();                 //Methode aus Versicherungsobjekt

            Versicherungsobjekt vo1 = new Versicherungsobjekt();
            vo1.Auszahlen();                //Nur Methoden der Basisklasse sind sichtbar
        }
    }
    class Versicherungsobjekt
    {
        protected double neupreis;
        protected int baujahr;
        protected double schadenshöhe;

        public void Auszahlen()
        {
            Console.WriteLine("Auszahlung");
        }
    }
    class KFZ : Versicherungsobjekt
    {
        private string? hersteller;
        private string? typenschlüssel;
        private int laufleistung;

        public void RestwertBerechnen()
        {
            Console.WriteLine("Restwert von KFZ");
        }
        public void AusgabeAttribute()
        {
            Console.WriteLine(this.baujahr );
        }
    }
    class Immobilie : Versicherungsobjekt
    {
        private double wohnfläche;
        private string? lagebewertung;

        public void RestwertBerechnen()
        {
            Console.WriteLine("Restwert von Immobilie");
        }
        public string? GetLagebewertung()
        {
            return lagebewertung;
        }
    }
}