namespace BeispielConstructur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("Trabant", 150);
            Auto a2 = new Auto("Papamobil");
            Auto a3 = new Auto(500); 
        }
    }
    class Auto
    {
        private string marke;
        private int ps;
        public Auto(int ps) : this("Ferrari", ps) { }
        public Auto(string marke) : this(marke, 50) 
        {
            //marke = m;
            //ps=50;
        }
        public Auto(string marke, int ps) 
        {
            this.marke = marke; 
            this.ps = ps;
        }
        public string GetMarke() { return marke; }
        public int Getps() { return ps; }
    
    }
}