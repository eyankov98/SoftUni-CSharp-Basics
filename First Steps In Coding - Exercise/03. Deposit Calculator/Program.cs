using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем данните от депозита
            //-  Депозирана сума – double
            //-  Срок на депозита (в месеци) - int
            //-  Годишен лихвен процент - double
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            //2. Изчисляваме сумата:
            // сума = депозит + срок * ((депозит * годишен лихвен процент) / 12)
            double sum = deposit + term * ((deposit * rate / 100) / 12);
            //3. Отпечатваме резултата на конзолата (сума)
            Console.WriteLine(sum);
        }
    }
}
