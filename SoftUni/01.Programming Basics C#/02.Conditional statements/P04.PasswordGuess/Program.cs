using System;

namespace P03.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Password = "s3cr3t!P@ssw0rd";

            string guess = Console.ReadLine();

            //string result = Password == guess ? "Welcome" : "Wrong password!";
            //Console.WriteLine(result);

            switch (guess)
            {
                case Password:
                    Console.WriteLine("Welcome");
                    break;
                default:
                    Console.WriteLine("Wrong password!");
                    break;
            }
        }
    }
}
