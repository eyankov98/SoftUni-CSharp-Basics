using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем от конзолата цена на екскурзия
            double excursionPrice = double.Parse(Console.ReadLine());
            //Четем количество на всеки от видовете играчки (пъзели, кукли, мечета, миньони, камиончета)
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            //Намираме общото количество продадени играчки
            int toysQuantity = puzzles + dolls + bears + minions + trucks;
            //Намираме общата печалбата от продадените играчки
            double money = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            //Проверяваме дали общия брой на играчките е >=50
            //=> ако е : трябва да се направи остъпка 25% от обаща цена
            if (toysQuantity >= 50)
            {
                //(money -= money * 0.25)
                money = money - money * 0.25;
            }
            //Изваждаме 10% от печалбата за наем(money -= money * 0.10)
            money = money - money * 0.10;
            //Проверяваме дали печалбата е достатъчно за екскурзията
            if (money >= excursionPrice)
            //=> ако е : "Yes! {оставащите пари} lv left."
            {
                Console.WriteLine($"Yes! {money - excursionPrice:f2} lv left.");
            }
            else
            //=> ако не е : "Not enough money! {недостигащите пари} lv needed.
            {
                Console.WriteLine($"Not enough money! {excursionPrice - money:f2} lv needed.");
            }
        }
    }
}
