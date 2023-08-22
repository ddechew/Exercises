using System;

namespace P18.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double BasketballSneakersPercentageCosts = 0.4;
            const double BasketballClothingPercantageCosts = 0.2;
            const double BasketballBallPercentageCosts = 0.25;
            const double BasketballAccessoriesPercentageCosts = 0.2;

            ushort yearlyBasketballTax = ushort.Parse(Console.ReadLine());

            double basketballSneakersCosts = yearlyBasketballTax * (1 - BasketballSneakersPercentageCosts);
            double basketballClothingCosts = basketballSneakersCosts * (1 - BasketballClothingPercantageCosts);
            double basketballBallCost = basketballClothingCosts * BasketballBallPercentageCosts;
            double basketballAccessoriesCosts = basketballBallCost * BasketballAccessoriesPercentageCosts;

            double totalCosts = basketballSneakersCosts + basketballClothingCosts + basketballBallCost + basketballAccessoriesCosts + yearlyBasketballTax;

            Console.WriteLine(totalCosts);
        }
    }
}
