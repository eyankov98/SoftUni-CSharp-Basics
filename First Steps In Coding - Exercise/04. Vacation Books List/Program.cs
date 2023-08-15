using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем общите данни и ги записваме в променливи от тип int
            //- брой страници
            // - страници който чете за 1 час 
            // - броя на дните 
            int pages = int.Parse(Console.ReadLine());
            int pagePerHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            //2 . Използваме общото време: брой страници / страници за 1 час
            int totalHours = pages / pagePerHours;
            //3. Необходимите часове на ден: общото време / даните с който разполага
            int hoursPerDay = totalHours / days;
            //4. Отпечатваме резултата ( Необходимите часове на ден)
            Console.WriteLine(hoursPerDay);
        }
    }
}
