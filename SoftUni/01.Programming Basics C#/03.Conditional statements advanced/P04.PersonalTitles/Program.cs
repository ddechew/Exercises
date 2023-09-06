using System;

namespace P04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];
            string title = string.Empty;

            if (gender == 'f')
            {
                if (age >= 16)
                {
                    title = "Ms.";
                }
                else
                {
                    title = "Miss";
                }
            }
            else if (gender == 'm')
            {
                if (age >= 16)
                {
                    title = "Mr.";
                }
                else
                {
                    title = "Master";
                }
            }

            Console.WriteLine(title);
        }
    }
}
