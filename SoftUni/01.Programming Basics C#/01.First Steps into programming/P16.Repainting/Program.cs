using System;

namespace P16.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SafetyNaylonPricePerSqrMeter = 1.50;
            const double PaintingPricePerLitre = 14.5;
            const double PaintThinnerPricePerLitre = 5;
            const double BagsPrice = 0.4;
            const byte AdditionalNaylon = 2;
            const double AdditionalPaintingPercantage = 0.1;
            const double WorkerCostsPercentageFromTotalMaterials = 0.3;

            byte safetyNaylonCount = byte.Parse(Console.ReadLine());
            byte paintingLitres = byte.Parse(Console.ReadLine());
            byte paintThinnerLitres = byte.Parse(Console.ReadLine());
            byte hoursToCompleteWork = byte.Parse(Console.ReadLine());

            double naylonCosts = (safetyNaylonCount + AdditionalNaylon) * SafetyNaylonPricePerSqrMeter;
            double paintingCosts = paintingLitres * (1 + AdditionalPaintingPercantage) * PaintingPricePerLitre;
            double paintThinnerCosts = paintThinnerLitres * PaintThinnerPricePerLitre;
            double bagsCosts = BagsPrice;

            double totalMaterialCosts = naylonCosts + paintingCosts + paintThinnerCosts + bagsCosts;
            double workersCosts = totalMaterialCosts * WorkerCostsPercentageFromTotalMaterials * hoursToCompleteWork;
            double finalCosts = totalMaterialCosts + workersCosts;

            Console.WriteLine(finalCosts);
        }
    }
}
