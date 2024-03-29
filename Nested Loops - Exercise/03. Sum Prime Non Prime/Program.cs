﻿using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (command != "stop")
            {
                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }

                bool isPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    sumPrime = sumPrime + number;
                }
                else if (!isPrime)
                {
                    sumNonPrime = sumNonPrime + number;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
