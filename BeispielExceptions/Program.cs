using System.Runtime.CompilerServices;

namespace BeispielExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fehler = true;
            do
            {
                decimal zahl1 = InputInt2("Erste Zahl: ");
                decimal zahl2 = InputInt2("Zweite Zahl: ");
                if (zahl2 != 0)
                {
                    //double erg;
                    //bool ok = Division(zahl1, zahl2, out erg);
                    Console.WriteLine(zahl1 / zahl2);
                    fehler = false;
                }
                else
                {
                    Console.WriteLine($"Die zweite Zahl darf nicht 0 sein!");
                }
            }
            while (fehler);
        }
        static decimal InputInt(string text)
        {
            decimal input = 0;
            bool fehler = true;
            do
            {
                try
                {
                    Console.Write(text);
                    input = decimal.Parse(Console.ReadLine());
                    fehler = false;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Nochmal, du Honk!");
                }

            }
            while (fehler);
            return input;
        }
        static decimal InputInt2(string text)
        {
            decimal input;
            bool ok;
            do
            {
                Console.Write(text);
                ok = decimal.TryParse(Console.ReadLine(), out input);
            }
            while (!ok);
            return input;
        }
        //static bool Division(decimal z1, decimal z2, out decimal erg)
        //{
        //    if (z2 != 0) 
        //    {
        //        erg = z1 / z2;
        //        return true;
        //    }
        //    erg = 0;
        //    return false;
        //}
    }
}