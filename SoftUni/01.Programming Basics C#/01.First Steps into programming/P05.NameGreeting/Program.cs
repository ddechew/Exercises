using System;

namespace P05.NameGreeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
            //Console.WriteLine("Hello, {0}!", name);
            //Console.WriteLine("Hello, " + name + "!");
        }
    }
}
