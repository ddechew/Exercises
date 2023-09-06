using System;

namespace P12.Godzilla.vs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Discount = 0.1;
            const double DecorExpensePercentage = 0.1;

            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double uniformPrice = double.Parse(Console.ReadLine());

            if (statists > 150)
            {
                uniformPrice *= 1 - Discount;
            }

            double uniformExpenses = statists * uniformPrice;
            double decorExpenses = budget * DecorExpensePercentage;
            double totalExpenses = uniformExpenses + decorExpenses;

            double money = budget - totalExpenses;

            if (money >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {money:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(money):F2} leva more.");
            }
        }
    }
}
