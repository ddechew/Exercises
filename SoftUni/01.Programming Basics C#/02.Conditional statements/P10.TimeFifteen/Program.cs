using System;

namespace P10.TimeFifteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MinuteAddition = 15;

            int hour = int.Parse(Console.ReadLine()) % 24;
            int minutes = int.Parse(Console.ReadLine());

            minutes += MinuteAddition;
            if (minutes >= 45)
            {
                int currentMinutes = minutes % 60;
                int hoursToAdd = minutes / 60;
                hour += hoursToAdd;

                if (hour > 23)
                {
                    hour %= 24;
                }

                Console.WriteLine($"{hour}:{currentMinutes:D2}");

            }
            else
            {
                Console.WriteLine($"{hour}:{minutes:D2}");
            }
        }
    }
}
