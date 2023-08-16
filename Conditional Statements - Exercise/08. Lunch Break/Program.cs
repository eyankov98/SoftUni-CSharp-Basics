using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем от конзолата: име на сериал, време на епизод, обедна почивка
            string seriesName = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int lunchTime = int.Parse(Console.ReadLine());
            // Изчисляваме колко време от почивката оста за сериал
            double timeForSeries = lunchTime * 5 / 8.00;
            //Проверяваме дали времето е достатъчно
            if (timeForSeries >= seriesTime)
            //=> достатъчно е(Резултата трябва да се форматира нагоре)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries - seriesTime)} minutes free time.");
            }
            else
            //=> Не е достатъчно(Резултата трябва да се форматира нагоре)
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes.");
            }
        }
    }
}
