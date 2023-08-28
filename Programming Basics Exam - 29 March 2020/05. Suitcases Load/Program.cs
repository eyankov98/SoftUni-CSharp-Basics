using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacityOfLuggagePlace = double.Parse(Console.ReadLine());
            string input = string.Empty;
            int suitcase = 0;
            int loadedSuitcase = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                suitcase++;
                double volumeOfLuggage = double.Parse(input);

                if ((suitcase % 3 == 0) && (capacityOfLuggagePlace < volumeOfLuggage * 1.1))
                {
                    break;
                }

                if ((suitcase % 3 != 0) && (capacityOfLuggagePlace < volumeOfLuggage))
                {
                    break;
                }

                if (suitcase % 3 == 0)
                {
                    capacityOfLuggagePlace -= volumeOfLuggage * 0.1;
                }

                capacityOfLuggagePlace -= volumeOfLuggage;
                loadedSuitcase++;
            }

            if (input == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }

            Console.WriteLine($"Statistic: {loadedSuitcase} suitcases loaded.");
        }
    }
}
