using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int schoolClass = 1;

            double sumGrades = 0;

            int excludCount = 0;

            while (schoolClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    excludCount++;

                    if (excludCount == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {schoolClass} grade");
                        return;
                    }
                }
                else
                {
                    schoolClass++;
                }
                sumGrades = sumGrades + grade;
            }
            double avarageGrade = sumGrades / 12;

            Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:f2}");
        }
    }
}
