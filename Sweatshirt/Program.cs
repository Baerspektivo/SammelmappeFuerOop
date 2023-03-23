namespace Sweatshirt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sweatshirt dry = new Sweatshirt();
            Sweatshirt wash = new Sweatshirt();
            Sweatshirt shirt1 = new Sweatshirt("lila", 36, true);
            Sweatshirt shirt2 = new Sweatshirt();
            shirt1.GetInfo();
            Console.Write("You will wash you're Shirt? ");
            wash.SetWash(Console.ReadLine());
            wash.GetWash();
            Console.Write("You will dry you're Shirt? ");
            dry.SetDry(Console.ReadLine());
            dry.GetDry();
            shirt2.GetInfo();
            Console.Write("You will wash you're Shirt? ");
            wash.SetWash(Console.ReadLine());
            wash.GetWash();
            Console.Write("You will dry you're Shirt? ");
            dry.SetDry(Console.ReadLine());
            dry.GetDry();
        }
    }
    class Sweatshirt
    {
        //**Attribute**
        private string color;
        private int size;
        private bool isDry;
        private string wash;
        private string dry; 
        //**constructor**
        public Sweatshirt(string color, int size, bool isDry) { this.color = color; this.size = size; this.isDry = isDry; }
        public Sweatshirt(int size) : this("red", size, true) { }                                                                               
        public Sweatshirt(bool isDry) : this("blau", 50, isDry) { }
        public Sweatshirt(string color) : this(color, 50, true) { }
        public Sweatshirt(string color, int size) : this(color, size, true) { }
        public Sweatshirt(string color, bool isDry) : this(color, 50, isDry) { }
        public Sweatshirt(int size, bool isDry) : this("grün", size, isDry) { }
        public Sweatshirt() : this("braun", 25, false) { }
        public bool GetIsDry() { return isDry; }
        public int GetSize() { return size; }
        public string GetColor() { return color; }
        //**wish**
        public void SetWash(string wash) 
        { this.wash = wash; }
        public void SetDry(string dry)
        { this.dry = dry; }
        public string GetWash() 
        { 
            if (!string.IsNullOrEmpty(this.wash) && this.wash == "yes")
            { Console.WriteLine("it's washed"); return wash; }
            else
            { Console.WriteLine("it's dry"); return ""; }
        } 
        public string GetDry() 
        { 
            if (!string.IsNullOrEmpty(this.dry) && this.dry == "yes") 
            { Console.WriteLine("it's dry"); return dry; } 
            else 
            { Console.WriteLine("it's wet"); return ""; } 
        }
        //**infoprint** 
        public void GetInfo() 
        { 
            string text = isDry ? "dry" : "wet";
            Console.WriteLine($"Color: {GetColor()}, size: {GetSize()}, is it dry? {text}");
        }
    }
}