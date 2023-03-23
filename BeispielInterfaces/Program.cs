namespace BeispielInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IrgendwasMitFahren(new Auto());
            IrgendwasMitFahren(new AmphibienFahrzeug());
        }
        static void IrgendwasMitFahren(IFahren fahren)
        {
            Console.WriteLine("Diese Mehtode benötigt etwas das fahren kann.");
            fahren.Fahren();
        }
    }
}