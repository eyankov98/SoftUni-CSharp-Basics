using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;

            if (0 <= sales && sales <= 500)
            {
                if (city == "Sofia")
                {
                    commission = 0.05;
                }
                else if (city == "Varna")
                {
                    commission = 0.045;
                }
                else if (city == "Plovdiv")
                {
                    commission = 0.055;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                if (city == "Sofia")
                {
                    commission = 0.07;
                }
                else if (city == "Varna")
                {
                    commission = 0.075;
                }
                else if (city == "Plovdiv")
                {
                    commission = 0.08;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                if (city == "Sofia")
                {
                    commission = 0.08;
                }
                else if (city == "Varna")
                {
                    commission = 0.10;
                }
                else if (city == "Plovdiv")
                {
                    commission = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (sales > 10000)
            {
                if (city == "Sofia")
                {
                    commission = 0.12;
                }
                else if (city == "Varna")
                {
                    commission = 0.13;
                }
                else if (city == "Plovdiv")
                {
                    commission = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            double totalSum = sales * commission;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
