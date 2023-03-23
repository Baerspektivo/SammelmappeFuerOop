namespace BeispielAssoziation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class oop = new Class("OOP");
            Class sql = new Class("SQL");

            Room r1 = new Room("1");
            Room r2 = new Room("2");

            oop.SetRoom(r1);
            sql.SetRoom(r2);

            oop.PrintInfos();
            sql.PrintInfos();
            r1.PrintInfos();
            r2.PrintInfos();
        }
    }
}