using System;

namespace _03._Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string tool = Console.ReadLine();

            double difficultyPoints = 0;
            double performancePoints = 0;

            double maxPoints = 20;

            if (country == "Russia")
            {
                if (tool == "ribbon")
                {
                    difficultyPoints = 9.100;
                    performancePoints = 9.400;
                }
                else if (tool == "hoop")
                {
                    difficultyPoints = 9.300;
                    performancePoints = 9.800;
                }
                else if (tool == "rope")
                {
                    difficultyPoints = 9.600;
                    performancePoints = 9.000;
                }
            }

            else if (country == "Bulgaria")
            {
                if (tool == "ribbon")
                {
                    difficultyPoints = 9.600;
                    performancePoints = 9.400;
                }
                else if (tool == "hoop")
                {
                    difficultyPoints = 9.550;
                    performancePoints = 9.750;
                }
                else if (tool == "rope")
                {
                    difficultyPoints = 9.500;
                    performancePoints = 9.400;
                }
            }

            else if (country == "Italy")
            {
                if (tool == "ribbon")
                {
                    difficultyPoints = 9.200;
                    performancePoints = 9.500;
                }
                else if (tool == "hoop")
                {
                    difficultyPoints = 9.450;
                    performancePoints = 9.350;
                }
                else if (tool == "rope")
                {
                    difficultyPoints = 9.700;
                    performancePoints = 9.150;
                }
            }

            double finalPoints = difficultyPoints + performancePoints;
            Console.WriteLine($"The team of {country} get {finalPoints:f3} on {tool}.");

            double neededPoints = maxPoints - finalPoints;
            double percentNeededPoints = (neededPoints / maxPoints) * 100;
            Console.WriteLine($"{percentNeededPoints:f2}%");
        }
    }
}
