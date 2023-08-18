using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evalution = Console.ReadLine();
            int nightings = daysToStay - 1;

            double price = 0;

            if (typeOfRoom == "apartment")
            {
                price = nightings * 25;

                if (nightings < 10)
                {
                    price = price - price * 0.30;
                }
                else if (nightings <= 15)
                {
                    price = price - price * 0.35;
                }
                else if (nightings > 15)
                {
                    price = price - price * 0.50;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                price = nightings * 35;

                if (nightings < 10)
                {
                    price = price - price * 0.10;
                }
                else if (nightings <= 15)
                {
                    price = price - price * 0.15;
                }
                else if (nightings > 15)
                {
                    price = price - price * 0.20;
                }
            }
            else
            {
                if (typeOfRoom == "room for one person")
                {
                    price = nightings * 18;
                }
            }
            if (evalution == "positive")
            {
                price = price + price * 0.25;
            }
            else if (evalution == "negative")
            {
                price = price - price * 0.10;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
