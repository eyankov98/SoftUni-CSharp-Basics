using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalCountOfPeople = 0;

            double group1 = 0; // Мусала
            double group2 = 0; // Монблан
            double group3 = 0; // Килиманджаро
            double group4 = 0; // К2
            double group5 = 0; // Еверест

            for (int i = 1; i <= n; i++)
            {
                int countOfPeople = int.Parse(Console.ReadLine());

                totalCountOfPeople = totalCountOfPeople + countOfPeople;

                if (countOfPeople <= 5)
                {
                    group1 = group1 + countOfPeople;
                }
                else if (countOfPeople >= 6 && countOfPeople <= 12)
                {
                    group2 = group2 + countOfPeople;
                }
                else if (countOfPeople >= 13 && countOfPeople <= 25)
                {
                    group3 = group3 + countOfPeople;
                }
                else if (countOfPeople >= 26 && countOfPeople <= 40)
                {
                    group4 = group4 + countOfPeople;
                }
                else if (countOfPeople >= 41)
                {
                    group5 = group5 + countOfPeople;
                }
            }

            group1 = group1 / totalCountOfPeople * 100;
            group2 = group2 / totalCountOfPeople * 100;
            group3 = group3 / totalCountOfPeople * 100;
            group4 = group4 / totalCountOfPeople * 100;
            group5 = group5 / totalCountOfPeople * 100;

            Console.WriteLine($"{group1:f2}%");
            Console.WriteLine($"{group2:f2}%");
            Console.WriteLine($"{group3:f2}%");
            Console.WriteLine($"{group4:f2}%");
            Console.WriteLine($"{group5:f2}%");
        }
    }
}
