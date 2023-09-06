namespace P14.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte degrees = byte.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            bool isCoolTemp = 10 <= degrees && degrees <= 18;
            bool isAverageTemp = 18 < degrees && degrees <= 24;
            bool isHotTemp = 25 <= degrees;

            string outfit = string.Empty;
            string shoes = string.Empty;

            if (timeOfDay == "Morning")
            {
                if (isCoolTemp)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (isAverageTemp)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (isHotTemp)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (isCoolTemp)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (isAverageTemp)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (isHotTemp)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeOfDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}