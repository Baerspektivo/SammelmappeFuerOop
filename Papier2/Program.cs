namespace Papier2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Papier a4 = new Papier(29.7, 21);
            //a4.SetLength(293.3);
            //a4.SetWight(212);
            a4.PrintInfos();
        }
    }

    class Papier
    {
        private double lengthInCm;
        private double widthInCm;
        public Papier(double l, double w)
        {
            lengthInCm = l;
            widthInCm = w;
        }
        public double GetLengthInCm() { return lengthInCm; }
        //public void setlength(double l) 
        //{ 
        //    if (lengthincm == 0 && 1 > 0) 
        //    { lengthincm = l; } 
        //}
        public double GetWidthInCm() {  return widthInCm; }
        //public void SetWight(double w)
        //{
        //    if (widthInCm == 0 && w > 0)
        //    { widthInCm = w; }
        //}
        public double GetArea()
        { return GetLengthInCm() * GetWidthInCm(); }
        public void PrintInfos()
        { 
            Console.Write($"Das Papier mit der Länge {GetLengthInCm():F2} cm");
            Console.Write($" und der Breite {GetWidthInCm():F2} cm");
            Console.WriteLine($" hat eine Fläche von {GetArea()/10000:F2} Quadratmeter.");
        }
    }
}