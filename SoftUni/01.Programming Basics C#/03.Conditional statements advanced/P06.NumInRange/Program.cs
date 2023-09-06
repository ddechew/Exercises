namespace P06.NumInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());

            if (number != 0 && number >= -100 && number <= 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}