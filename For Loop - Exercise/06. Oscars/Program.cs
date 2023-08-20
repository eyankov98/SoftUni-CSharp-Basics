using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsOfAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string nameOfAssessor = Console.ReadLine();
                double pointsOfAssessor = double.Parse(Console.ReadLine());

                pointsOfAcademy = pointsOfAcademy + ((nameOfAssessor.Length * pointsOfAssessor) / 2);

                if (pointsOfAcademy > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {pointsOfAcademy:f1}!");
                    break;
                }
            }

            if (pointsOfAcademy < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - pointsOfAcademy:f1} more!");
            }
        }
    }
}
