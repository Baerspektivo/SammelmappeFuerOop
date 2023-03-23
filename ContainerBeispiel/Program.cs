namespace ContainerBeispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datenbeschaffung = Beispielexemplar einer formatierung Datei
            string daten = "123; Hammer, Dübel, Nägel\n223; Fischfutter, Sand, Schlauch\n434; Pfanne, Gabel\n001; Apfel, Flasche, Tisch\n727; Laptop, Kabel, Tapete";
            //Console.WriteLine(daten);
            //Console.WriteLine("Datensätze erstellen: ");
            string[] datensätze = daten.Split('\n');
            //foreach  (string item in datensätze)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Keys von Values Trennen: ");
            string[] Schlüssel = new string[datensätze.Length];
            string[] Werte = new string[datensätze.Length];
            for (int i = 0; i < datensätze.Length -1; i++)
            {
                //Console.WriteLine(i);
                Schlüssel[i] = datensätze[i].Split(";")[0];
                //Console.WriteLine(Schlüssel[i]);
                Werte[i] = datensätze[i].Split(";")[1];
                //Console.WriteLine(Werte[i]);
            }
            //Console.WriteLine("Die isolierten Schlüssel");
            //foreach (var item in Schlüssel)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Die islolierten Werte");
            //foreach (var item in Werte)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("Dictronary<string ,List<string>> erstellen und füllen");
            Dictionary<string, List<string>> kundennummerZuWare = new Dictionary<string, List<string>>();
            for (int i = 0; i < Schlüssel.Length-1; i++)
            {
                string[] einzelneWerte = Werte[i].Split(",");
                kundennummerZuWare.Add(Schlüssel[i], einzelneWerte.ToList());
            }
            foreach (var item in kundennummerZuWare)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine("-" + item2);
                }
            }
        }
    }
}