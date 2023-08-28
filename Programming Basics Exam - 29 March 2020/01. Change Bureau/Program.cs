﻿using System;

namespace _01._Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberBitcoins = int.Parse(Console.ReadLine());
            double numberChineseYoans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinsPrice = numberBitcoins * 1168;
            double dollarsPrice = 1.76;
            double chineseYoansPrice = (dollarsPrice * 0.15) * numberChineseYoans;
            double euroPrice = 1.95;

            double sumInEuro = (bitcoinsPrice + chineseYoansPrice) / euroPrice;

            double finalComission = (comission / 100) * sumInEuro;

            double finalSum = sumInEuro - finalComission;

            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
