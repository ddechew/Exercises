using System;

namespace P13.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordToBeat = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());


            double secondsMade = distance * secondsPerMeter + (Math.Floor(distance / 15) * 12.5);
            double secondsLeft = secondsMade - recordToBeat;
            if (secondsLeft < 0)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {secondsMade:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(secondsLeft):F2} seconds slower.");
            }
        }
    }
}
