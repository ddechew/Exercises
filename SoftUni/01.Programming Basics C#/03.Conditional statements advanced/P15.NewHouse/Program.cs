namespace P15.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double RosePrice = 5;
            const double DahliaPrice = 3.8;
            const double TulipPrice = 2.8;
            const double NarcissusPrice = 3;
            const double GladiolusPrice = 2.5;

            const double RosesDiscount = 0.1;
            const double DahliasDiscount = 0.15;
            const double TulipsDiscount = 0.15;
            const double NarcissusesAddition = 0.15;
            const double GladiolusAddition = 0.2;

            string flowerType = Console.ReadLine();
            ushort flowerQuantity = ushort.Parse(Console.ReadLine());
            ushort budget = ushort.Parse(Console.ReadLine());
            double costs = 0;

            switch (flowerType)
            {
                case "Roses":
                    costs = RosePrice * flowerQuantity;

                    if (flowerQuantity > 80)
                    {
                        costs *= 1 - RosesDiscount;
                    }
                    break;
                case "Dahlias":
                    costs = DahliaPrice * flowerQuantity;

                    if (flowerQuantity > 90)
                    {
                        costs *= 1 - DahliasDiscount;
                    }
                    break;
                case "Tulips":
                    costs = TulipPrice * flowerQuantity;

                    if (flowerQuantity > 80)
                    {
                        costs *= 1 - TulipsDiscount;
                    }
                    break;
                case "Narcissus":
                    costs = NarcissusPrice * flowerQuantity;

                    if (flowerQuantity < 120)
                    {
                        costs *= 1 + NarcissusesAddition;
                    }
                    break;
                case "Gladiolus":
                    costs = GladiolusPrice * flowerQuantity;

                    if (flowerQuantity < 80)
                    {
                        costs *= 1 + GladiolusAddition;
                    }
                    break;
            }

            double moneyAfterCosts = Math.Abs(budget - costs);

            if (budget >= costs)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {moneyAfterCosts:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyAfterCosts:F2} leva more.");
            }
        }
    }
}