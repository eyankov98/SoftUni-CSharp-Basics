using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goal = 0;

            string input = Console.ReadLine();

            while (input != "Going home")
            {
                int steps = int.Parse(input);

                goal = goal + steps;

                if (goal >= 10000)
                {
                    goal = goal - 10000;

                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{goal} steps over the goal!");
                    return;
                }

                input = Console.ReadLine();
            }
            int stepsToHome = int.Parse(Console.ReadLine());
            goal = goal + stepsToHome;

            if (goal >= 10000)
            {
                goal = goal - 10000;

                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{goal} steps over the goal!");
            }
            else
            {
                goal = 10000 - goal;
                Console.WriteLine($"{goal} more steps to reach goal.");
            }
        }
    }
}
