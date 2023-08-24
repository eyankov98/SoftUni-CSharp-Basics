using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
                int number = i;
                int evenSum = 0;
                int oddSum = 0;

                for (int j = 6; j >= 1; j--)
                {
                    int eachNumber = number % 10;

                    if (j % 2 == 0)
                    {
                        evenSum = evenSum + eachNumber;
                    }
                    else if (j % 2 != 0)
                    {
                        oddSum = oddSum + eachNumber;
                    }

                    number = number / 10;
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
