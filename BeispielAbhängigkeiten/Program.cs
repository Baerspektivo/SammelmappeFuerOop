namespace BeispielAbhängigkeiten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student udo = new Student("Udo");
            Book b1 = new Book("SQL", "Alles über SQL und noch viel mehr ...");
            Book b2 = new Book("OOP", "Alles über OOP und noch viel mehr ...");
            Book b3 = new Book("TCP", "Alles über TCO und noch viel menr ...");

            udo.ReadBook(b1);
            udo.ReadBook(b2); 
            udo.ReadBook(b3);
        }
    }
}