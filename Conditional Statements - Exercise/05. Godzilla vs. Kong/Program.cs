using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Четем входа от конолата: бюджет, брой статисти, цена за дрехи 
            double filmBudget = double.Parse(Console.ReadLine());
            int numberExtras = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            //Намираме цена за декор => 10% (0.10) от бюджета 
            double decorPrice = filmBudget * 10 / 100.00;
            //Намираме цена за облекло на статистите =>брой статисти*цена
            double priceForExtras = numberExtras * clothingPrice;
            //=>проверяваме дали броя статисти е >150 
            if (numberExtras > 150)
            //==> ако е: начисляваме 10% отстъпка на облекло (priceForExtras -= priceForExtras*0.10)
            {
                priceForExtras = priceForExtras - priceForExtras * 10 / 100.00;
            }
            //Намираме общите разходи за заснемане (декор+облеклото)
            double money = priceForExtras + decorPrice;
            double difference = filmBudget - money;
            //Проверяваме дали бюджета е достатъчен
            if (difference >= 0)
            {
                //ако е =>
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                //ако НЕ е =>
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }
        }
    }
}
