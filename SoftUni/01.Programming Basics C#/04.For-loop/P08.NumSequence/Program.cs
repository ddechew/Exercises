namespace P08.NumSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNum = int.MinValue;
            int smallestNum = int.MaxValue;

            for (int i = 0; i < n; i++) 
            {
                int num = int.Parse(Console.ReadLine());

                if (num > biggestNum)
                {
                    biggestNum = num;
                }
                if (num < smallestNum)
                {
                    smallestNum = num;
                }
            }

            Console.WriteLine($"Max number: {biggestNum}");
            Console.WriteLine($"Min number: {smallestNum}");
        }
    }
}