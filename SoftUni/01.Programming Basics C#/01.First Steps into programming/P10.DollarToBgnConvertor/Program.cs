using System;

namespace P10.DollarToBgnConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double UsdToBgnValue = 1.79549;

            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * UsdToBgnValue;

            Console.WriteLine(bgn);
        }
    }
}
