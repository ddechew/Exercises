namespace P21.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double RentSingleRoomPrice = 18;

            const double RentApartmentPrice = 25;
            const double HighApartmentDiscount = 0.5;
            const double AverageApartmentDiscount = 0.35;
            const double SmallApartmentDiscount = 0.3;

            const double RentPresidentApartment = 35;
            const double HighPresidentApartDiscount = 0.2;
            const double AveragePresidentApartDiscount = 0.15;
            const double SmallPresidentApartDiscount = 0.1;

            const double PositiveGradeMultiplier = 0.25;
            const double NegativeGradeMultiplier = 0.1;

            ushort daysStaying = ushort.Parse(Console.ReadLine());
            ushort nightsCount = (ushort)(daysStaying - 1);
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();

            double totalExpenses = 0;

            if (roomType == "room for one person")
            {
                totalExpenses += RentSingleRoomPrice * nightsCount;
            }
            else if (roomType == "apartment")
            {
                totalExpenses += RentApartmentPrice * nightsCount;

                if (daysStaying > 15)
                {
                    totalExpenses *= 1 - HighApartmentDiscount;
                }
                else if (daysStaying >= 10)
                {
                    totalExpenses *= 1 - AverageApartmentDiscount;
                }
                else
                {
                    totalExpenses *= 1 - SmallApartmentDiscount;
                }
            }
            else if (roomType == "president apartment")
            {
                totalExpenses += RentPresidentApartment * nightsCount;

                if (daysStaying > 15)
                {
                    totalExpenses *= 1 - HighPresidentApartDiscount;
                }
                else if (daysStaying >= 10)
                {
                    totalExpenses *= 1 - AveragePresidentApartDiscount;
                }
                else
                {
                    totalExpenses *= 1 - SmallPresidentApartDiscount;
                }
            }

            if (grade == "positive")
            {
                totalExpenses *= 1 + PositiveGradeMultiplier;
            }
            else if (grade == "negative")
            {
                totalExpenses *= 1 - NegativeGradeMultiplier;
            }

            Console.WriteLine($"{totalExpenses:F2}");
        }
    }
}