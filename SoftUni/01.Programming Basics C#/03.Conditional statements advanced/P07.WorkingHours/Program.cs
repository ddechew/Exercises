namespace P07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte time = byte.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string state = "closed";

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (time >= 10 && time <= 18)
                    {
                        state = "open";
                    }
                    break;
            }

            Console.WriteLine(state);
        }
    }
}