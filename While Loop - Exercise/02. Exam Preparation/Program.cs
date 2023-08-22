using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countUnsatisfactoryGrades = int.Parse(Console.ReadLine());
            string nameExercise = Console.ReadLine();

            int countBadGrades = 0;
            string lastNameExercise = "";
            int countExercise = 0;
            int sumGrades = 0;


            while (nameExercise != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    countBadGrades++;

                    if (countBadGrades == countUnsatisfactoryGrades)
                    {
                        Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
                        return;
                    }
                }

                sumGrades = sumGrades + grade;
                countExercise++;
                lastNameExercise = nameExercise;

                nameExercise = Console.ReadLine();
            }

            double avarageGrade = (double)sumGrades / countExercise;

            Console.WriteLine($"Average score: {avarageGrade:f2}");
            Console.WriteLine($"Number of problems: {countExercise}");
            Console.WriteLine($"Last problem: {lastNameExercise}");
        }
    }
}
