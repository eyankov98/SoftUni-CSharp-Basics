using System;

namespace _03._World_Snooker_Championship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string partOfChampionship = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());
            double ticketPrice = 0;
            double photoWithTrophy = 40;

            if (partOfChampionship == "Quarter final")
            {
                if (typeTicket == "Standard")
                {
                    ticketPrice = 55.50;
                }
                else if (typeTicket == "Premium")
                {
                    ticketPrice = 105.20;
                }
                else if (typeTicket == "VIP")
                {
                    ticketPrice = 118.90;
                }
            }
            else if (partOfChampionship == "Semi final")
            {
                if (typeTicket == "Standard")
                {
                    ticketPrice = 75.88;
                }
                else if (typeTicket == "Premium")
                {
                    ticketPrice = 125.22;
                }
                else if (typeTicket == "VIP")
                {
                    ticketPrice = 300.40;
                }
            }
            else if (partOfChampionship == "Final")
            {
                if (typeTicket == "Standard")
                {
                    ticketPrice = 110.10;
                }
                else if (typeTicket == "Premium")
                {
                    ticketPrice = 160.66;
                }
                else if (typeTicket == "VIP")
                {
                    ticketPrice = 400;
                }
            }
            double totalMoney = ticketPrice * numberOfTickets;
            if (totalMoney > 4000)
            {
                totalMoney = totalMoney * 0.75;
                photo = 'N';
            }
            else if (totalMoney > 2500)
            {
                totalMoney = totalMoney * 0.9;
            }
            if (photo == 'Y')
            {
                totalMoney = totalMoney + numberOfTickets * 40;
            }
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
