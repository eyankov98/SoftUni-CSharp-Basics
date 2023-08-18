using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем от конзолата месец и дни престой
            // - May, June, July, August, September, October
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartamentPrice = 0;
            //Правим проверки за месеците:
            if (month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartamentPrice = nights * 65;

                if (nights > 14)
                {
                    //studioPrice -= studioPrice * 0.30;
                    studioPrice = studioPrice - studioPrice * 0.30;
                    apartamentPrice -= apartamentPrice * 0.10;
                }
                else if (nights > 7)
                {
                    studioPrice -= studioPrice * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 75.20;
                apartamentPrice = nights * 68.70;
                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartamentPrice -= apartamentPrice * 0.10;
                }
            }
            else // July и August
            {
                studioPrice = nights * 76;
                apartamentPrice = nights * 77;

                if (nights > 14)
                {
                    apartamentPrice -= apartamentPrice * 0.10;
                }
            }
            Console.WriteLine($"Apartment: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
