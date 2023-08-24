using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();

            int allFilmsTickets = 0;
            int student = 0;
            int standard = 0;
            int kid = 0;

            while (filmName != "Finish")
            {
                int freeSpace = int.Parse(Console.ReadLine());

                string ticketsType = Console.ReadLine();
                int totalTickets = 0;

                while (ticketsType != "End")
                {
                    allFilmsTickets++;

                    if (ticketsType == "student")
                    {
                        student++;
                    }
                    else if (ticketsType == "standard")
                    {
                        standard++;
                    }
                    else if (ticketsType == "kid")
                    {
                        kid++;
                    }


                    totalTickets++;
                    if (totalTickets == freeSpace)
                    {
                        break;
                    }

                    ticketsType = Console.ReadLine();
                }

                double ticketPercent = (double)totalTickets / freeSpace * 100;
                Console.WriteLine($"{filmName} - {ticketPercent:f2}% full.");

                filmName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {allFilmsTickets}");

            double procentStudent = (double)student / allFilmsTickets * 100;
            double procentStandard = (double)standard / allFilmsTickets * 100;
            double procentKid = (double)kid / allFilmsTickets * 100;

            Console.WriteLine($"{procentStudent:f2}% student tickets.");
            Console.WriteLine($"{procentStandard:f2}% standard tickets.");
            Console.WriteLine($"{procentKid:f2}% kids tickets.");
        }
    }
}
