namespace BeispielProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Auto a1 = new Auto();
            //a1.SetMarke("Fiat");
            //a1.Modell = "500";
            //Console.WriteLine(a1.Modell);
            Quadrat q = new Quadrat(5);
            Console.WriteLine(q.Breite);
            Console.WriteLine(q.Umfang);
            Console.WriteLine(q.Flaeche);
            
        }
        class Auto
        {
            private string marke;
            private string modell;
            public string Modell
            { 
                get { return modell; }
                set { modell = value; } 
            }
            //private int baujahr;
            //public int Baujahr
            //{
            //    get { return baujahr; }
            //    set { baujahr = value;}
            //}
            public int Baujahr { get; set; }
            public string GetMarke()
            { return marke; }
             public void SetMarke(string marke)
            { this.marke = marke; }
        }
        class Quadrat 
        {
            private int breite;
            public int Breite
            {
                get { return breite; }
                private set {
                    if (value > 0)
                        { breite = value;}
                    }
            }
            public int Umfang
            { 
                get { return breite *4; } 
            }
            public int Flaeche
            {
                get { return breite * breite; }
            }
            public Quadrat(int breite)
            { Breite = breite; }
        }
    }
}