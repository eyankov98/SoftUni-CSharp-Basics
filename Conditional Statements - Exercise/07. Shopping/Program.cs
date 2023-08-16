using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetPetur = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());

            double sumVideoCards = videoCards * 250;
            double priceProcessors = sumVideoCards * 35 / 100.00;
            double sumProcessors = processors * priceProcessors;
            double priceRamMemory = sumVideoCards * 10 / 100.00;
            double sumRamMemory = ramMemory * priceRamMemory;
            double totalSum = sumVideoCards + sumProcessors + sumRamMemory;


            if (videoCards > processors)
            {
                totalSum = totalSum - totalSum * 15 / 100.00;
            }
            if (totalSum <= budgetPetur)
            {
                Console.WriteLine($"You have {budgetPetur - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budgetPetur:f2} leva more!");
            }
        }
    }
}
