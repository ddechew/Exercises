using System;

namespace P09.LandscapingYards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PricePerSquareMeter = 7.61;
            const double Discount = 0.18;

            ushort sqrMeteres = ushort.Parse(Console.ReadLine());
            decimal price = (decimal)(sqrMeteres * PricePerSquareMeter);
            decimal discountedValue = price * (decimal)Discount;
            decimal finalPrice = price - discountedValue;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discountedValue:F2} lv.");

        }
    }
}
