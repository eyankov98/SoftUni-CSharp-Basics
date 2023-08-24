using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecial = true;
                int number = i;

                for (int j = 1; j <= 4; j++)
                {
                    int digit = number % 10;
                    number = number / 10;

                    if (digit == 0)
                    {
                        isSpecial = false;
                    }
                    else if (n % digit != 0)
                    {
                        isSpecial = false;
                    }
                    else if (n < digit)
                    {
                        isSpecial = false;
                    }
                }

                if (isSpecial == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
