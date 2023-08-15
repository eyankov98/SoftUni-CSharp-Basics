using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            int reduction = int.Parse(Console.ReadLine());

            double pricePackPens = pens * 5.80;
            double pricePackMarkers = markers * 7.20;
            double priceBoardCleaner = boardCleaner * 1.20;
            double finalReduction = reduction / 100.00;
            double sum = pricePackPens + pricePackMarkers + priceBoardCleaner;
            double priceReduction = sum - (sum * finalReduction);

            Console.WriteLine(priceReduction);
        }
    }
}
