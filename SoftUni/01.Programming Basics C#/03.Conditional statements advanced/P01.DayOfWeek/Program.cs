using System;
using System.Collections.Generic;

namespace P01.DayOfWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> daysOfWeek = new Dictionary<int, string>()
            {
                { 1, "Monday" }, { 2, "Tuesday" }, { 3, "Wednesday" }, { 4, "Thursday" }, { 5, "Friday" }, { 6, "Saturday" }, { 7, "Sunday" },
            };

            byte dayOfWeek = byte.Parse(Console.ReadLine());

            DateTime day = new DateTime();

            if (daysOfWeek.ContainsKey(dayOfWeek))
            {
                Console.WriteLine(daysOfWeek[dayOfWeek]);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

