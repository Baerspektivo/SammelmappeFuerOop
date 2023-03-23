using System;
using System.Security.Principal;

namespace Person_03_03_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Bitte stell dich vor. ");
            person.SetName(Console.ReadLine());
            Console.WriteLine("{0} bitte sag uns bitte dein alter.", person.GetName());
            person.SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("{0} bitte sag uns noch wann dein Geburtstag ist.", person.GetName());
            person.SetDay(Console.ReadLine());
        }
    }
    class Person
    {
        private string name;
        private int age;
        private string day;
        public string GetName()
        { return name; }
        public void SetName(string n)
        { name = n; }
        public int GetAge()
        {
            if (string.IsNullOrEmpty(day))
            { return age; }
            else
            { return age + 1; }
        }
        public void SetAge(int a)
        { age = a; }
        public void SetDay(string d)
        { day = d; }
        public string GetDay()
        { return day; }
        public void AusGabe() 
        {
            if (string.IsNullOrEmpty(GetDay()))
            { Console.WriteLine($"{GetName()} leider hattest du noch kein Geburtstag {GetAge()}."); }
            else
            { Console.WriteLine($"{GetName()} du bist ein Jahr älter als du angegeben hast {GetAge()}."); }
        }
    }
}