﻿using System;

namespace P09.FruitOrVeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string type = string.Empty;

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    type = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    type = "vegetable";
                    break;
                default:
                    type = "unknown";
                    break;
            }

            Console.WriteLine(type);
        }
    }
}
