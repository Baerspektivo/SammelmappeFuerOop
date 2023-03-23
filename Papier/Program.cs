namespace Papier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flaeche papier = new Flaeche();
            Console.Write("Länge eingeben: ");
            papier.SetLaenge(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Breite eingeben: ");
            papier.SetBreite(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Die Länge beträgt {papier.GetLaenge():F2} cm, die Breite beträgt {papier.GetBreite():F2} cm und die Fälche beträgt {papier.GetFlaeche():F2} qm");
        }
    }
    class Flaeche
    {
        private double breite;
        private double laenge;       
        public void SetBreite(double b)
        { breite = b; }
        public void SetLaenge(double l)
        { laenge = l; }
        public double GetBreite() { return breite; }
        public double GetLaenge() { return laenge; }
        public double GetFlaeche()
        { return ((GetBreite()/100) * (GetLaenge()/100)); }
    }
}