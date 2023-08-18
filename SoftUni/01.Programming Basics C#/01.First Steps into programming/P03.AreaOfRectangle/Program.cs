using System;

namespace P03.AreaOfRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int rectArea = a * b;

            Console.WriteLine(rectArea);
        }
    }
}
