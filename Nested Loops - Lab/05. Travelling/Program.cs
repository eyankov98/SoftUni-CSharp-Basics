using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double budgetNeeded;
            double savedMoney = 0;
            double money = 0;

            while (destination != "End")
            {
                budgetNeeded = double.Parse(Console.ReadLine());
                savedMoney = 0;
                while (budgetNeeded > savedMoney)
                {
                    money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
