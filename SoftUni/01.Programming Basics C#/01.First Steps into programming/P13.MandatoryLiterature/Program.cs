using System;

namespace P13.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort bookPages = ushort.Parse(Console.ReadLine());
            ushort pagesReadPerHour = ushort.Parse(Console.ReadLine());
            ushort daysRequiredToFinish = ushort.Parse(Console.ReadLine());

            double timeRequiredPerDay = Math.Floor(bookPages / (double)daysRequiredToFinish / pagesReadPerHour);
            Console.WriteLine(timeRequiredPerDay);
            
        }
    }
}
