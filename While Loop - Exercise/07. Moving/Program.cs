using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int freeSpace = width * length * height;

            int totalCubicMeters = 0;

            while (command != "Done")
            {
                int cubicMeters = int.Parse(command);

                totalCubicMeters = totalCubicMeters + cubicMeters;

                if (totalCubicMeters > freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {totalCubicMeters - freeSpace} Cubic meters more.");
                    return;
                }

                command = Console.ReadLine();
            }

            if (freeSpace > totalCubicMeters)
            {
                Console.WriteLine($"{freeSpace - totalCubicMeters} Cubic meters left.");
            }
        }
    }
}
