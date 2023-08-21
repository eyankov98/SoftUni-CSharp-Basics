using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumNumbers = 0;

            while (number > sumNumbers)
            {
                int numbers = int.Parse(Console.ReadLine());

                sumNumbers = sumNumbers + numbers;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
