namespace BeispielContainer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "15;D;Peter Schmidt;Wuppertal\n"
                        + "17;D;Hans Meier;Düsseldorf\n"
                        + "23;E;Regina Schulz;Mettmann\n"
                        + "31;D;Kathrin Müller;Erkrath\n"
                        + "32;E;Rudolf Kramer;Witten\n"
                        + "35;E;Anne Kunze;Bremen";
            string[] datensatz = text.Split('\n');
            string[] buchungsID = new string[datensatz.Length];
            string[] zimmer = new string[datensatz.Length];
            string[] vorname = new string[datensatz.Length];
            string[] nachname = new string[datensatz.Length];
            string[] wohnort = new string[datensatz.Length];
            for (int i = 0; i < datensatz.Length; i++)
            {
                buchungsID[i] = datensatz[i].Split(';')[0];
                zimmer[i] = datensatz[i].Split(";")[1].Replace("D", "Doppelzimmer").Replace("E", "Einzelzimmer");
                vorname[i] = datensatz[i].Split(";")[2].Split(" ")[0];
                nachname[i] = datensatz[i].Split(";")[2].Split(" ")[1];
                wohnort[i] = datensatz[i].Split(";")[3];
            }
            for (int i = 0; i < datensatz.Length; i++)
            {
                Console.WriteLine("Zimmer:      " + buchungsID[i]);
                Console.WriteLine("        " + zimmer[i]);
                Console.WriteLine("Vorname:     " + vorname[i]);
                Console.WriteLine("Nachname:    " + nachname[i]);
                Console.WriteLine("Wohnort:     " + wohnort[i]);
                Console.WriteLine();
            }
            List<Dictionary<string, string>> hotelZimmerBuchungsListe = new List<Dictionary<string, string>>();
            for (int i = 0; i < buchungsID.Length; i++)
            {
                Dictionary<string, string> bookingList = new Dictionary<string, string>();
                bookingList.Add("Zimmer: ", buchungsID[i]);
                bookingList.Add("     ", zimmer[i]);
                bookingList.Add("Vorname: ", vorname[i]);
                bookingList.Add("Nachname: ", nachname[i]);
                bookingList.Add("Wohnort: ", wohnort[i]);
                hotelZimmerBuchungsListe.Add(bookingList);
            }
            foreach (var bookinglist in hotelZimmerBuchungsListe)
            {
                foreach (var item2 in bookinglist)
                {
                    Console.WriteLine(item2.Key + " " + item2.Value);
                }
                Console.WriteLine();
            }
        }
    }
}