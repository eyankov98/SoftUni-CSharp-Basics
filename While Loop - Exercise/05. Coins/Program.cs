using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine()) * 100;

            int coinsCount = 0;

            while (coins >= 200)
            {
                coins = coins - 200;
                coinsCount++;
            }

            while (coins >= 100)
            {
                coins = coins - 100;
                coinsCount++;
            }

            while (coins >= 50)
            {
                coins = coins - 50;
                coinsCount++;
            }

            while (coins >= 20)
            {
                coins = coins - 20;
                coinsCount++;
            }
            while (coins >= 10)
            {
                coins = coins - 10;
                coinsCount++;
            }

            while (coins >= 5)
            {
                coins = coins - 5;
                coinsCount++;
            }

            while (coins >= 2)
            {
                coins = coins - 2;
                coinsCount++;
            }

            while (coins >= 1)
            {
                coins = coins - 1;
                coinsCount++;
            }

            Console.WriteLine(coinsCount);
        }
    }
}
