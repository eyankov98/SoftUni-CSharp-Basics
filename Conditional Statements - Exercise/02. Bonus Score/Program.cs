using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем number от конзолата
            int number = int.Parse(Console.ReadLine());
            //Създаваме променлива за бонусите
            double bonus = 0.0;
            //Начисляваме бонус спрямо размера на числото
            if (number <= 100)
            {
                //number<=100; => бонус = 5т.
                bonus = 5;
            }
            else if (number > 1000)
            {
                //number > 1000; => бонус = 10% от number (10%=0.1 / 10*100.00)
                bonus = number * 10 / 100.00;
            }
            else
            {
                //number > 100; => бонус = 20% от number (20%=0.2 / 20*100.00)
                bonus = number * 20 / 100.00;
            }
            //Проверяваме дали има допълнителни бонус точки:
            if (number % 2 == 0)
            {
                //ако number е четно - бонус = 1т.
                bonus = bonus + 1;
                //bonus += 1;
            }
            else if (number % 10 == 5)
            {
                //ако number завършва на 5 -бонус = 2т.
                bonus = bonus + 2;
                //bonus += 2;
            }
            //Отпечатваме резултата на конзолата
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
