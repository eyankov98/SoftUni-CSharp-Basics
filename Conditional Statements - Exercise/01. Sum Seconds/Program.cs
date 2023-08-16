using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем от конзолата времето на 3мата състезатели (в секунди)
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            //Намираме сумарно за колко секунди са финиширали (в секунди)
            int totalTime = firstTime + secondTime + thirdTime;
            //Превръщаме секундите в минути и секунди
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            //Правим проверка с оператор if и отпечатваме общия сбор в правилния формат (минути:секунди)
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
