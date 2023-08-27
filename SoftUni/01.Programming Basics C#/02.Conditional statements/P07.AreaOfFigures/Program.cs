using System;

namespace P07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double result = 0;

            if (figureType == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double squareArea = Math.Pow(a, 2);
                result = squareArea;
            }
            else if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double rectangleArea = a * b;
                result = rectangleArea;
            }
            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * Math.Pow(r, 2);
                result = circleArea;
            }
            else if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double triangleArea = side * height / 2;
                result = triangleArea;
            }

            if (result != 0)
            {
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
