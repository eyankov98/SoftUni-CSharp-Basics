using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            if (projectionType == "Premiere")
            {
                totalIncome = rows * columns * 12;
            }
            else if (projectionType == "Normal")
            {
                totalIncome = rows * columns * 7.50;
            }
            else if (projectionType == "Discount")
            {
                totalIncome = rows * columns * 5.00;
            }
            Console.WriteLine($"{totalIncome:f2} leva");
        }
    }
}
