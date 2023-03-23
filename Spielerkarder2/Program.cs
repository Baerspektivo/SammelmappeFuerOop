namespace Spielerkarder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spieler[] mannschaft = new Spieler[11];
            for (int i = 0; i < mannschaft.Length; i++) 
            {
                mannschaft[i] = new Spieler("Spieler " + (i + 1));
            }
            //Änderung der Marktwerte für 34 Spieltage
            for (int spieltag = 0; spieltag < 34; spieltag++)
            {
                for (int spieler = 0; spieler < mannschaft.Length; spieler++)
                {
                    mannschaft[spieler].MarktwertZufall();
                }
            }
            foreach (Spieler spieler in mannschaft)
            {
                spieler.PrintInfos();
                spieler.MarktwertZufall();
                spieler.PrintInfos();
                Console.WriteLine();
            }
            Spieler.PrintInfosAll();
            foreach (Spieler spieler in mannschaft)
            {
                spieler.PrintInfos();
            }
            Spieler.Verkauf();
        }
        class Spieler
        {
            private string name;
            private int transfergeb;
            private int marktwert;
            private Random rnd = new Random();

            private static int trasfergebAll;
            private static int marktwertAll;


            public Spieler(string name)
            {
                this.name = name;
                this.transfergeb = rnd.Next(1, 10) * 1_000_000;
                this.marktwert = this.transfergeb;
                trasfergebAll += transfergeb;
                marktwertAll += marktwertAll;
            }
            public void PrintInfos()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Transfergeb.: {transfergeb}");
                Console.WriteLine($"Marktwert: {marktwert}");
            }
            public static void PrintInfosAll()
            {
                Console.WriteLine($"Gesamte Transfergeb.: {trasfergebAll}");
                Console.WriteLine($"Gesamter Marktwert: {marktwertAll}");
            }
            public void MarktwertZufall()
            {
                int abweichung = rnd.Next(10) * 10_000 - 30_000;
                this.marktwert += abweichung;
                marktwertAll += abweichung;
            }
            public static void Verkauf()
            {
                if (marktwertAll > trasfergebAll)
                {
                    Console.WriteLine("Der verkauf lohnt sich.");
                }
                else if (marktwertAll < trasfergebAll)
                {
                    Console.WriteLine("Der Verkauf lohnt sich nicht.");
                }
                else
                {
                    Console.WriteLine("Wir machen weder Gewinn noch Verlust.");
                }
            }

        }
    }
}