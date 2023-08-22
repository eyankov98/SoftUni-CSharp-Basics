using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int cakeSize = width * length;

            while (command != "STOP")
            {
                int piecesTaken = int.Parse(command);

                cakeSize = cakeSize - piecesTaken;

                if (cakeSize <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {cakeSize * -1} pieces more.");
                    return;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{cakeSize} pieces are left.");
        }
    }
}
