﻿using System;

namespace _03._Fitness_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;

            if (sport == "Gym")
            {
                if (gender == "m")
                {
                    price = 42;
                }
                else if (gender == "f")
                {
                    price = 35;
                }
            }
            else if (sport == "Boxing")
            {
                if (gender == "m")
                {
                    price = 41;
                }
                else if (gender == "f")
                {
                    price = 37;
                }
            }
            else if (sport == "Yoga")
            {
                if (gender == "m")
                {
                    price = 45;
                }
                else if (gender == "f")
                {
                    price = 42;
                }
            }
            else if (sport == "Zumba")
            {
                if (gender == "m")
                {
                    price = 34;
                }
                else if (gender == "f")
                {
                    price = 31;
                }
            }
            else if (sport == "Dances")
            {
                if (gender == "m")
                {
                    price = 51;
                }
                else if (gender == "f")
                {
                    price = 53;
                }
            }
            else
            {
                if (gender == "m")
                {
                    price = 39;
                }
                else if (gender == "f")
                {
                    price = 37;
                }
            }
            if (age <= 19)
            {
                price = price - price * 0.20;
            }
            if (price <= sum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${price - sum:f2} more.");
            }
        }
    }
}