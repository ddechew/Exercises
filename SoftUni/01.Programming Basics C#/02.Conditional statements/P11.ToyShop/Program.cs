using System;

namespace P11.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PuzzlePrice = 2.6;
            const double DollPrice = 3;
            const double TeddyBearPrice = 4.1;
            const double MinionPrice = 8.2;
            const double TruckPrice = 2;
            const double DiscountPercentage = 0.25;
            const double RentPercentage = 0.10;

            double excursionPrice = double.Parse(Console.ReadLine());
            
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int teddyBearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double puzzleProfit = puzzleCount * PuzzlePrice;
            double dollProfit = dollCount * DollPrice;
            double teddyBearProfit = teddyBearCount * TeddyBearPrice;
            double minionProfit = minionCount * MinionPrice;
            double trucksProfit = trucksCount * TruckPrice;

            int productQty = puzzleCount + dollCount + teddyBearCount + minionCount + trucksCount;

            double totalProfit = puzzleProfit + dollProfit + teddyBearProfit + minionProfit + trucksProfit;

            if (productQty >= 50)
            {
                totalProfit *= 1 - DiscountPercentage;
            }

            totalProfit *= 1 - RentPercentage;

            double money = Math.Abs(totalProfit - excursionPrice);

            if (totalProfit >= excursionPrice)
            {
                Console.WriteLine($"Yes! {money:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {money:F2} lv needed.");
            }

        }
    }
}
