using System.Net.Sockets;
using System.Runtime.ExceptionServices;

namespace BeispielRekusion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FatultaetRekursiv(16062));
        }
        static long FakultaetIterativ(int n)
        {
            long ergebnis = 1;
            for (int i = 1; i <= n; i++)
            {
                ergebnis = ergebnis * i;
            }
            return ergebnis;
        }
        static ulong FatultaetRekursiv(ulong n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * FatultaetRekursiv(n-1);
            }
        }
    }
}