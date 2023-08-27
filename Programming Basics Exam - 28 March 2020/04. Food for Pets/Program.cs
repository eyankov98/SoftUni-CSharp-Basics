using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double totalFoodEatDog = 0;
            double totalFoodEatCat = 0;
            double totalFoodEat = 0;

            double totalBiscuits = 0;

            for (int i = 1; i <= countDays; i++)
            {
                int foodEatDog = int.Parse(Console.ReadLine());
                int foodEatCat = int.Parse(Console.ReadLine());

                totalFoodEatDog = totalFoodEatDog + foodEatDog;
                totalFoodEatCat = totalFoodEatCat + foodEatCat;
                totalFoodEat = totalFoodEat + foodEatDog + foodEatCat;

                if (i % 3 == 0)
                {
                    totalBiscuits = totalBiscuits + (foodEatDog + foodEatCat) * 0.10;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {totalBiscuits:f0}gr.");
            double percentFoodEat = (totalFoodEat / totalFood) * 100;
            Console.WriteLine($"{percentFoodEat:f2}% of the food has been eaten.");
            double percentDogEat = (totalFoodEatDog / totalFoodEat) * 100;
            Console.WriteLine($"{percentDogEat:f2}% eaten from the dog.");
            double percentCatEat = (totalFoodEatCat / totalFoodEat) * 100;
            Console.WriteLine($"{percentCatEat:f2}% eaten from the cat.");
        }
    }
}
