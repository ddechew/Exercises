using System;

namespace P12.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            byte depositTerm = byte.Parse(Console.ReadLine());
            double yearlyInterestRate = double.Parse(Console.ReadLine()) / 100;
            double yield = deposit + depositTerm * (deposit * yearlyInterestRate / 12);

            Console.WriteLine(yield);
        }
    }
}
