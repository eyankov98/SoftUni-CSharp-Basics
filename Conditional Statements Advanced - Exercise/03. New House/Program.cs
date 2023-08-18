using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (typeOfFlowers)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                default:
                    price = 2.50;
                    break;
            }
            double finalPrice = countOfFlowers * price;

            if (typeOfFlowers == "Roses" && countOfFlowers > 80)
            {
                finalPrice = finalPrice - finalPrice * 0.10;
            }
            else if (typeOfFlowers == "Dahlias" && countOfFlowers > 90)
            {
                finalPrice -= finalPrice * 0.15;
            }
            else if (typeOfFlowers == "Tulips" && countOfFlowers > 80)
            {
                finalPrice -= finalPrice * 0.15;
            }
            else if (typeOfFlowers == "Narcissus" && countOfFlowers < 120)
            {
                finalPrice = finalPrice + finalPrice * 0.15;
            }
            else if (typeOfFlowers == "Gladiolus" && countOfFlowers < 80)
            {
                finalPrice += finalPrice * 0.20;
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {budget - finalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
            }
        }
    }
}
