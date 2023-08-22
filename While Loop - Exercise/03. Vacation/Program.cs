using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());

            int countSpendDays = 0;

            int countDays = 0;

            while (moneyNeeded > moneyAvailable)
            {
                string command = Console.ReadLine();

                double sumSpendOrSave = double.Parse(Console.ReadLine());

                countDays++;

                if (command == "spend")
                {
                    countSpendDays++;

                    if (countSpendDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(countDays);
                        return;
                    }

                    moneyAvailable = moneyAvailable - sumSpendOrSave;

                    if (moneyAvailable <= 0)
                    {
                        moneyAvailable = 0;
                    }
                }
                else if (command == "save")
                {
                    countSpendDays = 0;
                    moneyAvailable = moneyAvailable + sumSpendOrSave;
                }
            }
            Console.WriteLine($"You saved the money for {countDays} days.");
        }
    }
}
