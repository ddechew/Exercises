namespace P10.InvalidNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            bool isInvalid = number != 0 && (number < 100 || number > 200);

            if (isInvalid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}