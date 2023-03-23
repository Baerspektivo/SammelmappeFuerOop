namespace BeispielÜberschreiben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug[] fahrzeuge = new Fahrzeug[5];

            fahrzeuge[0] = new Fahrzeug("AB-CD 123");
            fahrzeuge[1] = new Auto("XY-Z 987");
            fahrzeuge[2] = new Schiff("Evergiven");
            fahrzeuge[3] = new Ballon("Veltins");
            fahrzeuge[4] = new Fahrzeug("GH-IJ 567");

            foreach (Fahrzeug item in fahrzeuge)
            {
                item.Fahren();
            }
            
            Fahrzeug f1 = fahrzeuge[0];
            Console.WriteLine(f1);
            Console.WriteLine(f1.GetHashCode());
            Console.WriteLine(f1.Equals(fahrzeuge[0]));
            Console.WriteLine(f1.Equals(fahrzeuge[1]));
            Console.WriteLine(f1.GetType());
        }
    }
}