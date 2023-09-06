namespace P13.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PremierePrice = 12;
            const double NormalPrice = 7.5;
            const double DiscountedPrice = 5;

            string projectionType = Console.ReadLine();
            ushort rows = ushort.Parse(Console.ReadLine());
            ushort cols = ushort.Parse(Console.ReadLine());

            ushort totalViewers = (ushort)(rows * cols);
            double income = 0;


            if (projectionType == "Premiere")
            {
                income = totalViewers * PremierePrice;
            }
            else if (projectionType == "Normal")
            {
                income = totalViewers * NormalPrice;
            }
            else if (projectionType == "Discount")
            {
                income = totalViewers * DiscountedPrice;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}