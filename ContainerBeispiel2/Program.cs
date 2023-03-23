using System.Data;
using System.Security.Cryptography;

namespace ContainerBeispiel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string daten = "123; Hammer, Dübel, Nägel\n223; Fischfutter, Sand, Schlauch\n434; Pfanne, Gabel\n001; Apfel, Flasche, Tisch\n727; Laptop, Kabel, Tapete";
            //string[] datensätze = daten.Split('\n');
            //string[] Schlüssel = new string[datensätze.Length];
            //string[] Werte = new string[datensätze.Length];
            //for (int i = 0; i < datensätze.Length - 1; i++)
            //{
            //    Schlüssel[i] = datensätze[i].Split(";")[0];
            //    Werte[i] = datensätze[i].Split(";")[1];
            //}
            //Dictionary<string, List<string>> kundennummerZuWare = new Dictionary<string, List<string>>();
            //for (int i = 0; i < Schlüssel.Length - 1; i++)
            //{
            //    string[] einzelneWerte = Werte[i].Split(",");
            //    kundennummerZuWare.Add(Schlüssel[i], einzelneWerte.ToList());
            //}

            ////alle produkte in einer neuen liste sammeln
            //List<string> produkte = new List<string>();
            //foreach (var item in kundennummerZuWare)
            //{
            //    foreach (var item2 in item.Value)
            //    {
            //        produkte.Add(item2);
            //    }
            //}
            ////doppelte werte entfernen
            //List<string> eindeutigeProdukte = new List<string>();
            //foreach (var item in produkte)
            //{
            //    if (!eindeutigeProdukte.Contains(item))
            //    {
            //        eindeutigeProdukte.Add(item);
            //    }
            //}
            ////alle keys in einer neuen liste sammeln
            //List<string> keys = new List<string>();
            //foreach (var item in kundennummerZuWare)
            //{                
            //        keys.Add(item.Key);
            //}
            ////doppelte werte etfernen
            //List<string> eindeutigeKeys = new List<string>();
            //foreach (var item in keys)
            //{
            //    if (!eindeutigeKeys.Contains(item))
            //    {
            //        eindeutigeKeys.Add(item);
            //    }
            //}
            ////ausgabe
            //Dictionary<string, List<string>> wareZuKundennummer = new Dictionary<string, List<string>>();
            //foreach (var item in eindeutigeKeys)
            //{
            //   wareZuKundennummer.Add(item, new List<string>());
            //    foreach (var item2 in kundennummerZuWare)
            //    {
            //        foreach (var item3 in item2.Value)
            //        {
            //            if (wareZuKundennummer.ContainsKey(item3))
            //            {
            //                wareZuKundennummer[item3].Add(item2.Key);


            //                //wareZuKundennummer.Add(item3, item2.Key);
            //            }
            //        }
            //    }
            //}

            //Datenbeschaffung = Beispielexemplar einer formatierung Datei
            string daten = "123; Hammer, Dübel, Nägel\n223; Fischfutter, Sand, Schlauch\n434; Pfanne, Gabel\n001; Apfel, Flasche, Tisch\n727; Laptop, Kabel, Tapete";

            string[] datensätze = daten.Split('\n');

            string[] Schlüssel = new string[datensätze.Length];
            string[] Werte = new string[datensätze.Length];
            for (int i = 0; i < datensätze.Length - 1; i++)
            {
                Schlüssel[i] = datensätze[i].Split(";")[0];
                Werte[i] = datensätze[i].Split(";")[1];
            }

            Console.WriteLine("Dictronary<string ,List<string>> erstellen und füllen");
            Dictionary<string, List<string>> kundennummerZuWare = new Dictionary<string, List<string>>();
            for (int i = 0; i < Schlüssel.Length - 1; i++)
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
            Console.WriteLine("------------------------------------------------------------------------------");
            List<string> schlüsselliste = new List<string>();
            foreach (var item in kundennummerZuWare)
            {
                foreach (var ware in item.Value)
                {
                    if (!schlüsselliste.Contains(ware))
                    {
                        schlüsselliste.Add(ware);
                    }
                }
            }
            Console.WriteLine("Prüfen ob die Schlüsseliste eindeutig ist");
            foreach (var item in schlüsselliste)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, List<string>> wareZuKundenNummer = new Dictionary<string, List<string>>();
            foreach (var item in schlüsselliste)
            {
                wareZuKundenNummer.Add(item, new List<string>());
            }
            Console.WriteLine("Prüfen ob alle schlüssel gesetzt sind");
            foreach (var item in wareZuKundenNummer)
            {
                Console.WriteLine(item.Key);
            }

            foreach (var wzkElement in wareZuKundenNummer)
            {
                foreach (var kzwElement in kundennummerZuWare)
                {
                    foreach (var produkt in kzwElement.Value)
                    {
                        if (wzkElement.Key == produkt)
                        {
                            wareZuKundenNummer[produkt].Add(kzwElement.Key);
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Prüfung wie das neue Dictionary aussieht: ");

            foreach (var item in wareZuKundenNummer)
            {
                Console.WriteLine("Artikel: " + item.Key);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine("-" + item2);
                }
            }
        }
    }
}