namespace BeispielExceptions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = {"abc","def","ghi","jkl","mno","qpr","stu" };
            PrintString(strings, 11);
        }
        /// <summary>
        /// Eine lustig Zusammenfassung 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="position"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        static void PrintString(string[] array, int position)
        {
            if (position < 0 || position > array.Length) 
            { 
                throw new ArgumentOutOfRangeException(nameof(position), position, "Außerhalb des Arrays");
            }
            Console.WriteLine(array[position]);
        }
    }
}