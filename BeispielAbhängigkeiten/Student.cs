using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielAbhängigkeiten
{
    internal class Student
    {
        private string name;
        private string wissen;
        public Student(string name)
        {
            this.name = name;
        }
        public void ReadBook(Book book)
        {
            string infos = book.GetInfos();
            wissen = wissen + "\n" + infos;
            Console.WriteLine("Ich habe gerade gelesen: ");
            Console.WriteLine(infos);
        }

    }
}
