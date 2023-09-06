using System;

namespace P08.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstRacerSeconds = int.Parse(Console.ReadLine());
            int secondRacerSeconds = int.Parse(Console.ReadLine());
            int thirdRacerSeconds = int.Parse(Console.ReadLine());

            int totalSeconds = firstRacerSeconds + secondRacerSeconds + thirdRacerSeconds;
            int minutes = totalSeconds / 60;
            int currentSeconds = totalSeconds % 60;
            string result = $"{minutes}:{currentSeconds:D2}";

            Console.WriteLine(result);
        }
    }
}
