using System;

namespace P19.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort length = ushort.Parse(Console.ReadLine());
            ushort width = ushort.Parse(Console.ReadLine());
            ushort height = ushort.Parse(Console.ReadLine());
            double percentageOccupied = double.Parse(Console.ReadLine()) / 100;

            double volume = length * width * height;
            double waterInTank = volume * (1 - percentageOccupied) / 1000;

            Console.WriteLine(waterInTank);
        }
    }
}
