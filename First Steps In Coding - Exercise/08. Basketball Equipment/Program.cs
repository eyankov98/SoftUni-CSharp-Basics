using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата таксата за 1 година
            int annualCharge = int.Parse(Console.ReadLine());
            //2. Намираме цена за кецове = 60% от годишната такса 
            double priceSneakers = annualCharge * 0.6;
            //3. Намираме цена за екип = 80% от цената за кецове
            double priceOutfit = priceSneakers * 0.8;
            //4. Намираме цена за топка = цена за екип / 4 
            double priceBall = priceOutfit / 4;
            //5. Намираме цена за аксесоари = цена за топка / 5
            double priceAccssories = priceBall / 5;
            //6. Намираме общата сума = такса за година + кецове + екип + топка + аксесоари
            double sum = annualCharge + priceSneakers + priceOutfit + priceBall + priceAccssories;
            //7. Отпечатаме резулатата на конзолата ( общата сума)
            Console.WriteLine(sum);
        }
    }
}
