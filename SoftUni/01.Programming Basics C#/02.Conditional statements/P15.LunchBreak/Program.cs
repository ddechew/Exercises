using System;

namespace P15.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double LunchLengthPercentage = 0.125;
            const double RelaxLengthPercentage = 0.25;

            string showName = Console.ReadLine();
            byte episodeLength = byte.Parse(Console.ReadLine());
            byte breakLength = byte.Parse(Console.ReadLine());
            double lunchLength = breakLength * LunchLengthPercentage;
            double relaxLength = breakLength * RelaxLengthPercentage;

            double totalFreeTimeForWatching = breakLength - (lunchLength + relaxLength);

            double timeDiff = Math.Ceiling(Math.Abs(totalFreeTimeForWatching - episodeLength));

            if (totalFreeTimeForWatching >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {showName} and left with {timeDiff} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {showName}, you need {timeDiff} more minutes.");
            }
        }
    }
}
