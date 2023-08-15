using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем данните от конзолата
            //- количество найлон - int 
            //- количество боя - int 
            //- количество разредител (в литри) - int 
            //- часовете - int
            int nylonQuantity = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int workingTime = int.Parse(Console.ReadLine());
            //2. Пресмятаме цената на всеки от материалите
            //- предпазен найлон 1.50лв за кв метър
            //- боя - 14.50лв за литър
            //- разредител за боя - 5лв за литър
            double nylonPrice = (nylonQuantity + 2) * 1.5;
            double paintPrice = (paintLiters + 0.1 * paintLiters) * 14.50;
            double thinnerPrice = thinnerLiters * 5;
            //3. Общата сума за материали (+ 0.40лв за торбичка)
            double materialsSum = nylonPrice + paintPrice + thinnerPrice + 0.40;
            //4. Изчисляваме парите за майстори (1 час работа = 30% от цената за материали)
            double workersSum = (0.3 * materialsSum) * workingTime;
            //5. Изчисляваме общата сума (материали и работа на майстори)
            double totalSum = materialsSum + workersSum;
            //6. Отпечатваме резултата на конзолата (общата сума за ремонт)
            Console.WriteLine(totalSum);
        }
    }
}
