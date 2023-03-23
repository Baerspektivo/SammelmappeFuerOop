using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielAbhängigkeiten
{
    internal class Book
    {
        private string content;
        private string title;
        
        public Book(string title, string content)
        {
            this.title = title;
            this.content = content;
        }
        public string GetInfos() { return this.content; }
    }
}
