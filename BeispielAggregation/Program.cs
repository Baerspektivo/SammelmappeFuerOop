namespace BeispielAggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student franzi = new Student("Franzi");
            Student huihui = new Student("Huhui");

            Class do7 = new Class("Do7", 5);

            do7.AddStudent(franzi);
            do7.AddStudent(huihui);
            do7.PrintInfos(); 
        }
    }
}