﻿using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (website == "Instagram")
                {
                    salary = salary - 100;
                }
                else if (website == "Reddit")
                {
                    salary = salary - 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
