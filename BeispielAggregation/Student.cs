using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielAggregation
{
    internal class Student
    {
        private string name;
        private Class _class;

        public Student(string name) 
        {
            this.name = name;
        }
        public string GetName() { return this.name; }
        public void SetClass(Class _class)
        {
            this._class = _class;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Der Student {name} ist in der klasse {_class.GetName()}");
        }
    }

}
