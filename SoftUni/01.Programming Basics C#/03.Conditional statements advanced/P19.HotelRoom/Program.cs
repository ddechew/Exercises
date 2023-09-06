namespace P19.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double MayOctStudioNightPrice = 50;
            const double MayOctApartmentNightPrice = 65;
            const double MayOctStudioSmallDiscount = 0.05;
            const double MayOctStudioHighDiscount = 0.3;

            const double JuneSeptStudioNightPrice = 75.2;
            const double JuneSeptApartmentNightPrice = 68.7;
            const double JuneSeptStudioDiscount = 0.2;

            const double JulAugStudioNightPrice = 76;
            const double JulAugApartmentNightPrice = 77;

            const double ApartmentDiscount = 0.1;

            string month = Console.ReadLine();
            byte nightsCount = byte.Parse(Console.ReadLine());

            double studioCosts = 0;
            double apartmentCosts = 0;

            if (month == "May" || month == "October")
            {
                studioCosts += MayOctStudioNightPrice * nightsCount;
                apartmentCosts += MayOctApartmentNightPrice * nightsCount;

                if (nightsCount > 14)
                {
                    studioCosts *= 1 - MayOctStudioHighDiscount;
                    apartmentCosts *= 1 - ApartmentDiscount;
                }
                else if (nightsCount > 7)
                {
                    studioCosts *= 1 - MayOctStudioSmallDiscount;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioCosts += JuneSeptStudioNightPrice * nightsCount;
                apartmentCosts += JuneSeptApartmentNightPrice * nightsCount;

                if (nightsCount > 14)
                {
                    studioCosts *= 1 - JuneSeptStudioDiscount;
                    apartmentCosts *= 1 - ApartmentDiscount;
                }

            }
            else if (month == "July" || month == "August")
            {
                studioCosts += JulAugStudioNightPrice * nightsCount;
                apartmentCosts += JulAugApartmentNightPrice * nightsCount;

                if (nightsCount > 14)
                {
                    apartmentCosts *= 1 - ApartmentDiscount;
                }
            }

            Console.WriteLine($"Apartment: {apartmentCosts:F2} lv.");
            Console.WriteLine($"Studio: {studioCosts:F2} lv.");
        }
    }
}