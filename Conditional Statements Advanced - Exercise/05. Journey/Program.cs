using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double moneySpent = 0;
            string typeVacation = ""; 
            string destination = ""; 

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    typeVacation = "Camp";
                    moneySpent = budget * 0.30;
                }
                else if (season == "winter")
                {
                    typeVacation = "Hotel";
                    moneySpent = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typeVacation = "Camp";
                    moneySpent = budget * 0.40;
                }
                else if (season == "winter")
                {
                    typeVacation = "Hotel";
                    moneySpent = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                    typeVacation = "Hotel";
                    moneySpent = budget * 0.90;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeVacation} - {moneySpent:f2}");
        }
    }
}
