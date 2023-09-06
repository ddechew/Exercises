namespace P17.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SummerLocation = "Camp";
            const string WinterLocation = "Hotel";

            const double SummerCheapLocationCosts = 0.3;
            const double WinterCheapLocationCosts = 0.7;
            const string CheapLocation = "Bulgaria";

            const double SummerMidmarketLocationCosts = 0.4;
            const double WinterMidmarketLocationCosts = 0.8;
            const string MidmarketLocation = "Balkans";

            const double ExpensiveLocationCosts = 0.9;
            const string ExpensiveLocation = "Europe";

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalCosts = 0;
            string location = string.Empty;
            string vacationType = season == "winter" ? WinterLocation : SummerLocation;

            if (budget > 1000)
            {
                location = ExpensiveLocation;
                totalCosts += budget * ExpensiveLocationCosts;
                vacationType = WinterLocation;
            }
            else if (budget > 100)
            {
                location = MidmarketLocation;
                if (season == "summer")
                {
                    totalCosts += budget * SummerMidmarketLocationCosts;
                }
                else if (season == "winter")
                {
                    totalCosts += budget * WinterMidmarketLocationCosts;
                }
            }
            else
            {
                location = CheapLocation;
                if (season == "summer")
                {
                    totalCosts += budget * SummerCheapLocationCosts;
                }
                else if (season == "winter")
                {
                    totalCosts += budget * WinterCheapLocationCosts;
                }
            }

            if (budget >= totalCosts)
            {
                Console.WriteLine($"Somewhere in {location}");
                Console.WriteLine($"{vacationType} - {totalCosts:F2}");
            }
        }
    }
}