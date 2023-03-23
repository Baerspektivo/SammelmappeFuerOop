namespace BeispielGenerischeTypen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stapel<Karte> stapel = new Stapel<Karte>();
            Karte karte1 = new Karte("Herz", "König");
            Karte karte2 = new Karte("Pik", "Ass");
            stapel.Push(karte1);
            stapel.Push(karte2);
            Console.WriteLine(stapel.Pop().Wert); 
            Console.WriteLine(stapel.Pop().Wert); 
            Console.WriteLine(stapel.IsEmpty()); 
        }
    }
}