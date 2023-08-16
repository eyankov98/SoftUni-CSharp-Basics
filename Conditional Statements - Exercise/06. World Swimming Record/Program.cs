using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем от конзолата световния рекорд
            // Четем от конзолата разстоянието което трябва да измине
            // Времето за което плува разстояние от 1м.
            double wordlRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());
            // Намираме забавянето => на всеки 15м се забавя с 12.5сек.
            double delay = Math.Floor(distance / 15) * 12.5;
            // Намираме какъв е рекорда на Иван
            double recordByIvan = distance * timePerMeter + delay;
            // Проверяваме дали Иван е успял да подобри световния рекорд
            if (recordByIvan < wordlRecord)
            //=> ако е успял:
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            //=> ако НЕ е успял:
            {
                Console.WriteLine($"No, he failed! He was {recordByIvan - wordlRecord:f2} seconds slower.");
            }
        }
    }
}
