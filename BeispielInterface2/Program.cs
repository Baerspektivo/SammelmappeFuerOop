namespace BeispielInterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodeProgrammablauf(new FileLogger());
            MethodeProgrammablauf(new DataBaseLogger());
        }
        static void MethodeProgrammablauf(ILogger logger)
        {
            Console.WriteLine("Die Methode macht aufregende Ding....");
            Console.WriteLine("Zwischendurch muss Sie Dinge Loggen.");
            logger.LogData("Wichtige Infos");
            Console.WriteLine("Und weitere aufgende Dinge Passieren....");
        }
    }
}