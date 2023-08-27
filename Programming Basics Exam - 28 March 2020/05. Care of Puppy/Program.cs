using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfFood = int.Parse(Console.ReadLine());
            amountOfFood = amountOfFood * 1000;

            int foodNeeded = 0;

            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int food = int.Parse(command);

                foodNeeded = foodNeeded + food;

                command = Console.ReadLine();
            }

            if (foodNeeded <= amountOfFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {amountOfFood - foodNeeded} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodNeeded - amountOfFood} grams more.");
            }
        }
    }
}
