using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.WeekendOrWorkday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] workingDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string[] restDays = { "Saturday", "Sunday" };

            string day = Console.ReadLine();

            if (workingDays.Contains(day))
            {
                Console.WriteLine("Working day");
            }
            else if (restDays.Contains(day))
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        static void SecondSolve()
        {
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
