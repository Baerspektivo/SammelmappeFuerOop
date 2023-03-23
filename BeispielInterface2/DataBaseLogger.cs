using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BeispielInterface2
{
    internal class DataBaseLogger : ILogger
    {
        public void LogData(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Der Text \"{text}\" wird in die Datenbank gespeicher");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
