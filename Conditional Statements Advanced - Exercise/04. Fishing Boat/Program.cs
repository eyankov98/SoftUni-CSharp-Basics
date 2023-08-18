using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishermen = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                price = 3000;

                if (countFishermen <= 6)
                {
                    price = price - price * 0.10;
                }
                else if (countFishermen >= 7 && countFishermen <= 11)
                {
                    price = price - price * 0.15;
                }
                else if (countFishermen >= 12)
                {
                    price = price - price * 0.25;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;

                if (countFishermen <= 6)
                {
                    price = price - price * 0.10;
                }
                else if (countFishermen >= 7 && countFishermen <= 11)
                {
                    price = price - price * 0.15;
                }
                else if (countFishermen >= 12)
                {
                    price = price - price * 0.25;
                }
            }
            else
            {
                price = 2600;

                if (countFishermen <= 6)
                {
                    price = price - price * 0.10;
                }
                else if (countFishermen >= 7 && countFishermen <= 11)
                {
                    price = price - price * 0.15;
                }
                else if (countFishermen >= 12)
                {
                    price = price - price * 0.25;
                }
            }
            if (countFishermen % 2 == 0 && season != "Autumn")
            {
                price = price - price * 0.05;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
