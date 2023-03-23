namespace BeispielThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person batman = new Person("Batman");
            Person robin = new Person("Robin");
            Console.WriteLine(batman.GetName());
            Console.WriteLine(robin.GetName());
            batman.SetPartner(robin);
            //robin.SetPartner(batman);
            Console.WriteLine($"Batmans Partner: {batman.GetPartner().GetName()}");
            Console.WriteLine($"Robins  Partner: {robin.GetPartner().GetName()}");
        }
    }
    class Person
    {
        private string name;
        private Person partner;
        public Person(string name)
        {
            this.name = name;
        }
        public string GetName() { return name; }
        public Person GetPartner() { return partner;}
        public void SetPartner(Person partner) 
        { 
            if (this.partner == null) 
            {
                this.partner = partner;
                this.partner.SetPartner(this);
            }
        }
    }
}