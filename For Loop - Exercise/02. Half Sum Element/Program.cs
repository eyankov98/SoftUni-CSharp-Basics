using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum = sum + number;

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            sum = sum - maxNumber;

            if (sum == maxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int diff = Math.Abs(sum - maxNumber);

                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
