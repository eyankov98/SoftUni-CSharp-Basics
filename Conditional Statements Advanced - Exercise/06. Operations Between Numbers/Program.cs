using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            // (+) (-) (*) (Изврършваме операциите по стандартния начин)
            if (operation == '+' || operation == '-' || operation == '*')
            {
                int result = 0;
                string evenOrOdd = "even";
                if (operation == '+')
                {
                    result = num1 + num2;
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                }
                else //*
                {
                    result = num1 * num2;
                }
                if (result % 2 != 0)
                {
                    evenOrOdd = "odd";
                }
                //Извеждаме резултат във формата:{число1} {знак} {число2} = {резултат} {even/odd(спрямо резултата)}
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else // (/) (%)
            {
                //Проверяваме число2 дали е 0
                //=>ако е 0: "Cannot divide {число1} by zero"
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                //=>ако НЕ е:
                // при (/) трябва да направим едно от числата double
                else if (operation == '/')
                {
                    double result = (double)num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {((double)num1 / num2):f2}");
                }
                else // (%)
                {
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }
            }
        }
    }
}
