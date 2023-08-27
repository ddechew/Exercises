using System;

namespace P01.ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.5 && grade <= 6)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
