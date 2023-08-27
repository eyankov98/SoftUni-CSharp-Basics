using System;

namespace _06._Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int tournamentWins = 0;
            int tournamentLoses = 0;
            double totalMoneyWon = 0;

            for (int i = 1; i <= days; i++)
            {
                int winForDay = 0;
                int loseForDay = 0;
                double moneyForDay = 0;

                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        winForDay++;
                        moneyForDay = moneyForDay + 20;
                    }
                    else if (result == "lose")
                    {
                        loseForDay++;
                    }

                    sport = Console.ReadLine();
                }

                if (winForDay > loseForDay)
                {
                    moneyForDay = moneyForDay + moneyForDay * 0.10;
                }

                tournamentWins = tournamentWins + winForDay;
                tournamentLoses = tournamentLoses + loseForDay;
                totalMoneyWon = totalMoneyWon + moneyForDay;
            }

            if (tournamentWins > tournamentLoses)
            {
                totalMoneyWon = totalMoneyWon + totalMoneyWon * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoneyWon:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoneyWon:f2}");
            }
        }
    }
}
