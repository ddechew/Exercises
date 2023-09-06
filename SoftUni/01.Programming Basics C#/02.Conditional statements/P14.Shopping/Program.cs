using System;

namespace P14.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double GraphicsCardPrice = 250;
            const double ProcessorPricePercentage = 0.35;
            const double RamPricePercentage = 0.1;
            const double DiscountPercentage = 0.15;

            double budget = double.Parse(Console.ReadLine());
            byte graphicsCardQty = byte.Parse(Console.ReadLine());
            byte processorQty = byte.Parse(Console.ReadLine());
            byte ramQty = byte.Parse(Console.ReadLine());

            double graphicsCardsExpenses = GraphicsCardPrice * graphicsCardQty;

            double processorPrice = graphicsCardsExpenses * ProcessorPricePercentage;
            double processorExpenses = processorPrice * processorQty;

            double ramPrice = graphicsCardsExpenses * RamPricePercentage;
            double ramExpenses = ramPrice * ramQty;

            double totalExpenses = graphicsCardsExpenses + processorExpenses + ramExpenses;

            if (graphicsCardQty > processorQty)
            {
                totalExpenses *= 1 - DiscountPercentage;
            }

            double balance = Math.Abs(budget - totalExpenses);

            if (budget >= totalExpenses)
            {
                Console.WriteLine($"You have {balance:F2} leva left!");
            } 
            else
            {
                Console.WriteLine($"Not enough money! You need {balance:F2} leva more!");
            }
        }
    }
}
