namespace P16.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SpringShipRentPrice = 3000;
            const double SummerAutumnShipRentPrice = 4200;
            const double WinterShipRentPrice = 2600;

            const double HighestDiscount = 0.25;
            const double AverageDiscount = 0.15;
            const double SmallestDiscount = 0.1;
            const double SeasonalDiscount = 0.05;


            ushort budget = ushort.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            byte fishermenCount = byte.Parse(Console.ReadLine());
            double totalCosts = 0;

            if (season == "Spring")
            {
                totalCosts += SpringShipRentPrice;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                totalCosts += SummerAutumnShipRentPrice;
            }
            else if (season == "Winter")
            {
                totalCosts += WinterShipRentPrice;
            }

            if (fishermenCount > 12)
            {
                totalCosts *= 1 - HighestDiscount;
            }
            else if (fishermenCount > 6)
            {
                totalCosts *= 1 - AverageDiscount;
            }
            else
            {
                totalCosts *= 1 - SmallestDiscount;
            }

            if (season != "Autumn" && fishermenCount % 2 == 0)
            {
                totalCosts *= 1 - SeasonalDiscount;
            }

            double netValue = Math.Abs(budget -  totalCosts);

            if (budget >= totalCosts)
            {
                Console.WriteLine($"Yes! You have {netValue:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {netValue:F2} leva.");
            }
        }
    }
}