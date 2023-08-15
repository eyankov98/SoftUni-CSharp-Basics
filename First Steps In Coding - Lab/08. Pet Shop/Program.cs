using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogPacks = int.Parse(Console.ReadLine());
            double dogPacksPrice = dogPacks * 2.5;

            int catPacks = int.Parse(Console.ReadLine());
            double catPacksPrice = catPacks * 4;

            double finalSum = dogPacksPrice + catPacksPrice;

            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
