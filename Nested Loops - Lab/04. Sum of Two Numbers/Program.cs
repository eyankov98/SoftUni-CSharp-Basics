using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combination = 0;
            int firstNumber = -1;
            int secondNumber = -1;

            bool isFound = false;
            for (int n1 = startNumber; n1 <= finalNumber; n1++)
            {
                for (int n2 = startNumber; n2 <= finalNumber; n2++)
                {
                    combination++;
                    if (n1 + n2 == magicNumber)
                    {
                        isFound = true;
                        firstNumber = n1;
                        secondNumber = n2;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Combination N:{combination} ({firstNumber} + {secondNumber} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
