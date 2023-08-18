using System;

namespace P04.InchToCmConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double InchToCm = 2.54;

            double inchValue = double.Parse(Console.ReadLine());
            double cmValue = inchValue * InchToCm;

            Console.WriteLine(cmValue);
        }
    }
}
