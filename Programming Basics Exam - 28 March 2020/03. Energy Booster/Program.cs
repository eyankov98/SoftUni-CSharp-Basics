using System;

namespace _03._Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double price = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    price = 2 * 56;
                }
                else if (size == "big")
                {
                    price = 5 * 28.70;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    price = 2 * 36.66;
                }
                else if (size == "big")
                {
                    price = 5 * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = 2 * 42.10;
                }
                else if (size == "big")
                {
                    price = 5 * 24.80;
                }
            }
            else
            {
                if (size == "small")
                {
                    price = 2 * 20;
                }
                else if (size == "big")
                {
                    price = 5 * 15.20;
                }
            }
            double totalPrice = count * price;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (totalPrice > 1000)
            {
                totalPrice = totalPrice - totalPrice * 0.50;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
