using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int columns = 1; columns <= row; columns++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                    if (currentNumber > n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
