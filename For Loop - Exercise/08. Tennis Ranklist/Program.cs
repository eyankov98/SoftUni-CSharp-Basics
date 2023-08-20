using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTournaments = int.Parse(Console.ReadLine());
            int startingCountOfPoints = int.Parse(Console.ReadLine());

            int points = 0;
            int countOfWonTournaments = 0;

            for (int i = 1; i <= countOfTournaments; i++)
            {
                string stageOfTournament = Console.ReadLine();

                if (stageOfTournament == "W")
                {
                    countOfWonTournaments++;
                    points = points + 2000;
                }
                else if (stageOfTournament == "F")
                {
                    points = points + 1200;
                }
                else if (stageOfTournament == "SF")
                {
                    points = points + 720;
                }
            }

            double avaragePoints = (double)points / countOfTournaments;
            double percentOfWonTournaments = ((double)countOfWonTournaments / countOfTournaments) * 100;

            Console.WriteLine($"Final points: {startingCountOfPoints + points}");
            Console.WriteLine($"Average points: {Math.Floor(avaragePoints)}");
            Console.WriteLine($"{percentOfWonTournaments:f2}%");
        }
    }
}
