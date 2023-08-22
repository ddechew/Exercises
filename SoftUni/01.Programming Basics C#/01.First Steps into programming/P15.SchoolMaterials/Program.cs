using System;

namespace P15.SchoolMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PenPackPrice = 5.80;
            const double MarkerPackPrice = 7.20;
            const double PreparationPricePerLitre = 1.20;

            byte penPackCount = byte.Parse(Console.ReadLine());
            byte markerPackCount = byte.Parse(Console.ReadLine());
            byte preparationLiters = byte.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine()) / 100;

            double penPackCosts = penPackCount * PenPackPrice;
            double markerPackCosts = markerPackCount * MarkerPackPrice;
            double preparationCosts = preparationLiters * PreparationPricePerLitre;

            double totalCosts = penPackCosts + markerPackCosts + preparationCosts;
            double finalCosts = totalCosts * (1 - discountPercentage);

            Console.WriteLine(finalCosts);
        }
    }
}
