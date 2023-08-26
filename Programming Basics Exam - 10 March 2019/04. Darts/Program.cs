using System;

namespace _04._Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int currentPoints = 301;
            string command = null;
            int successfulShots = 0;
            int unsuccessfulShots = 0;

            while ((command = Console.ReadLine()) != "Retire")
            {
                string gameSector = command;
                int pointsInput = int.Parse(Console.ReadLine());

                if (gameSector == "Single")
                {
                    currentPoints -= pointsInput;
                }

                if (gameSector == "Double")
                {
                    currentPoints -= pointsInput * 2;
                }

                if (gameSector == "Triple")
                {
                    currentPoints -= pointsInput * 3;
                }

                if (currentPoints < 0)
                {
                    unsuccessfulShots++;

                    if (gameSector == "Single")
                    {
                        currentPoints += pointsInput;
                    }
                    else if (gameSector == "Double")
                    {
                        currentPoints += pointsInput * 2;
                    }
                    else if (gameSector == "Triple")
                    {
                        currentPoints += pointsInput * 3;
                    }
                    continue;
                }

                else if (currentPoints > 0)
                {
                    successfulShots++;
                    continue;
                }

                else
                {
                    successfulShots++;
                    Console.WriteLine($"{playerName} won the leg with {successfulShots} shots.");
                    return;
                }

            }

            Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
        }
    }
}
