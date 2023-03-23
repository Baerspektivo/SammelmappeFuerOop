using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielInterface2
{
    internal class FileLogger : ILogger
    {
        public void LogData(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Der Text \"{text}\" wird in der Datei gespeicher");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
