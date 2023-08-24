using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double grade = 0;

            double sumTotalGrades = 0;
            int exercises = 0;


            while (command != "Finish")
            {
                double sumGrades = 0;

                for (int i = 1; i <= jury; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    sumGrades = sumGrades + grade;
                }

                double averageGrade = sumGrades / jury;
                Console.WriteLine($"{command} - {averageGrade:f2}.");

                sumTotalGrades = sumTotalGrades + averageGrade;
                exercises++;

                command = Console.ReadLine();
            }

            double averageTotalGrade = sumTotalGrades / exercises;

            Console.WriteLine($"Student's final assessment is {averageTotalGrade:f2}.");
        }
    }
}
