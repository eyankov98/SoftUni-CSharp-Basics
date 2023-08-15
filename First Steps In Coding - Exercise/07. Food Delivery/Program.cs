using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double priceChikenMenus = chickenMenus * 10.35;
            double priceFishMenus = fishMenus * 12.40;
            double priceVegetarianMenus = vegetarianMenus * 8.15;
            double priceMenus = priceChikenMenus + priceFishMenus + priceVegetarianMenus;
            double priceDessertMenus = (20 / 100.00) * priceMenus;
            double priceDelivery = 2.50;
            double sum = priceMenus + priceDessertMenus + priceDelivery;

            Console.WriteLine(sum);
        }
    }
}
