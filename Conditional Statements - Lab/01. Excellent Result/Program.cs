using System;

namespace _01._Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input(ВХОД)
            double grade = double.Parse(Console.ReadLine());
            //Act(ВЪРШИ ДЕЙСТВИЯ)
            if (grade >= 5.50)
            {
                //Outpu(ИЗХОД)
                Console.WriteLine("Excellent!");
            }
        }
    }
}
