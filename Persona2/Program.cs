using System.Net.NetworkInformation;
using System.Xml.Serialization;

namespace Persona2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            
            p.SetName("Osama");
            p.SetAge(35);
            p.SayHello();
            p.Birthday();
            p.SayHello();

            Person p2 = new Person();
            p2.SetName("Polly");
            p2.SetAge(27);
            p2.SayHello();
            p2.Birthday();
            p2.SayHello();

            Person p3 = new Person();
            p3.SetName("Anton");
            p3.SetAge(30);
            p3.SayHello();
            p3.Birthday();
            p3.SayHello();

            Console.WriteLine();
            Console.WriteLine();
        }

        class Person
        {
            private int age;
            private string name;
            public string GetName() 
            { return name; }
            public void SetName(string n ) 
            {
                if (name == null)
                { name = n; }
            }
            public int GetAge()
            { return age; }
            public void SetAge(int a) 
            { 
                if ( age == 0 && a > 0) { age = a; }
            }
            public void Birthday () 
            { 
                age++; 
            }
            public void SayHello() 
            { 
                Console.WriteLine($"Hallo mein Name ist {GetName()} und ich bin {GetAge()} Jahre alt.");
            }
        }

    }
}