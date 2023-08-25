using System;

namespace _06._High_Jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wantedHeight = int.Parse(Console.ReadLine());
            int startingHeight = wantedHeight - 30;

            int jumpHeight = 0;
            int fails = 0;
            int jumps = 0;

            for (int currentHeight = startingHeight; currentHeight <= wantedHeight; currentHeight += 5)
            {
                for (int tryNumber = 1; tryNumber <= 3; tryNumber++)
                {
                    jumpHeight = int.Parse(Console.ReadLine());

                    if (jumpHeight > currentHeight)
                    {
                        jumps++;
                        tryNumber = 3;
                    }

                    else if (jumpHeight <= currentHeight)
                    {
                        fails++;
                        jumps++;

                        if (fails == 3)
                        {
                            Console.WriteLine($"Tihomir failed at {currentHeight}cm after {jumps} jumps.");
                            return;
                        }
                    }
                }

                fails = 0;
            }

            Console.WriteLine($"Tihomir succeeded, he jumped over {wantedHeight}cm after {jumps} jumps.");
        }
    }
}
