using System;

namespace _05._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournirsNumber = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            string gameStatus;
            int sumPoints = 0;
            int wonTournirs = 0;

            for (int i = 1; i <= tournirsNumber; i++)
            {
                gameStatus = Console.ReadLine();

                if (gameStatus == "W")
                {
                    sumPoints += 2000;
                    wonTournirs++;
                }
                else if (gameStatus == "F")
                {
                    sumPoints += 1200;
                }
                else if (gameStatus == "SF")
                {
                    sumPoints += 720;
                }
            }

            int finalPoints = sumPoints + startingPoints;

            double averagePoints = (double)sumPoints / tournirsNumber;
            double wonTournirsPercent = (double)wonTournirs / tournirsNumber * 100;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{wonTournirsPercent:f2}%");
        }
    }
}
