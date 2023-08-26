using System;

namespace _01._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double shoes = yearTax - ((double)yearTax * 0.4);
            double set = shoes - (shoes * 0.2);
            double ball = set / 4;
            double accessories = ball / 5;
            double yearTaxSum = yearTax + shoes + set + ball + accessories;

            Console.WriteLine($"{yearTaxSum:f2}");
        }
    }
}
