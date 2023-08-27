using System;

namespace P04.NumberFrom100to200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = number < 100 ? "Less than 100" : number > 200 ? "Greater than 200" : "Between 100 and 200";
            Console.WriteLine(result);
        }
    }
}
