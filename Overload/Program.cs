namespace Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addiere(21,21));
            Console.WriteLine(Addiere(10,10,22));
        }
        static int Addiere(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }
        static int Addiere(int zahl1, int zahl2, int zahl3)
        {
            return zahl1 + zahl2 + zahl3;
        }
        static double Addiere(double zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }
    }
}