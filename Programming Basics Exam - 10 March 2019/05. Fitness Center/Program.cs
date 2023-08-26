using System;

namespace _05._Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 0; i < visitors; i++)
            {
                string activity = Console.ReadLine();

                if (activity == "Back")
                {
                    back++;
                }

                if (activity == "Chest")
                {
                    chest++;
                }

                if (activity == "Legs")
                {
                    legs++;
                }

                if (activity == "Abs")
                {
                    abs++;
                }

                if (activity == "Protein shake")
                {
                    proteinShake++;
                }

                if (activity == "Protein bar")
                {
                    proteinBar++;
                }
            }

            int peopleForWorkOut = back + chest + legs + abs;
            int peopleForProtein = proteinShake + proteinBar;

            double percentWorkOut = peopleForWorkOut * 1.0 / visitors * 100;
            double percentProtein = peopleForProtein * 1.0 / visitors * 100;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{percentWorkOut:f2}% - work out");
            Console.WriteLine($"{percentProtein:f2}% - protein");
        }
    }
}
