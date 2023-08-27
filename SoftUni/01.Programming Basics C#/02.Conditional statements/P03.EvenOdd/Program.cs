using System;

namespace P03.EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = number % 2 == 0 ? "even" : "odd";
            Console.WriteLine(type);
        }
    }
}
