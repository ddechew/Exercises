using System;

namespace P08.Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double DogFoodPrice = 2.50;
            const byte CatFoodPrice = 4;

            byte dogFoodQty = byte.Parse(Console.ReadLine());
            byte catFoodQty = byte.Parse(Console.ReadLine());
            double dogFoodExpenses = dogFoodQty * DogFoodPrice;
            double catFoodExpenses = catFoodQty * CatFoodPrice;

            double totalFoodExpenses = dogFoodExpenses + catFoodExpenses;

            Console.WriteLine($"{totalFoodExpenses} lv.");
        }
    }
}
