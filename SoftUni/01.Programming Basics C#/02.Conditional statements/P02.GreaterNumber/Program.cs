using System;

namespace P02.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int biggerNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine(biggerNumber);
        }
    }
}
