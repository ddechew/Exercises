namespace P12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double percentage = 0;

            if (salesVolume >= 0 && salesVolume <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.05;
                        break;
                    case "Varna":
                        percentage = 0.045;
                        break;
                    case "Plovdiv":
                        percentage = 0.055;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }
            else if (salesVolume > 500  &&  salesVolume <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.07;
                        break;
                    case "Varna":
                        percentage = 0.075;
                        break;
                    case "Plovdiv":
                        percentage = 0.08;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }
            else if (salesVolume > 1000 &&  salesVolume <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.08;
                        break;
                    case "Varna":
                        percentage = 0.1;
                        break;
                    case "Plovdiv":
                        percentage = 0.12;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }
            else if (salesVolume > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        percentage = 0.12;
                        break;
                    case "Varna":
                        percentage = 0.13;
                        break;
                    case "Plovdiv":
                        percentage = 0.145;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }

            double tradeCommission = salesVolume * percentage;

            Console.WriteLine($"{tradeCommission:F2}");
        }
    }
}