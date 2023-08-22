using System;

namespace P17.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double ChickenMenuPrice = 10.35;
            const double FishMenuPrice = 12.40;
            const double VegetarianMenuPrice = 8.15;
            const double DeliveryCosts = 2.50;
            const double DessertPercentageCosts = 0.2;

            byte chickenMenuOrders = byte.Parse(Console.ReadLine());
            byte fishMenuOrders = byte.Parse(Console.ReadLine());
            byte vegetarianMenuOrders = byte.Parse(Console.ReadLine());

            double chickenMenuCosts = chickenMenuOrders * ChickenMenuPrice;
            double fishMenuCosts = fishMenuOrders * FishMenuPrice;
            double vegetarianMenuCosts = vegetarianMenuOrders * VegetarianMenuPrice;
            
            double totalFoodCosts = chickenMenuCosts + fishMenuCosts + vegetarianMenuCosts;
            double dessertCosts = totalFoodCosts * DessertPercentageCosts;

            double finalCosts = totalFoodCosts + dessertCosts + DeliveryCosts;
            
            Console.WriteLine(finalCosts);
        }
    }
}
