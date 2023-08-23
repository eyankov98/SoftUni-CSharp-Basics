using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsCount = int.Parse(Console.ReadLine());

            for (int fl = floorsCount; fl >= 1; fl--)
            {
                for (int room = 0; room < roomsCount; room++)
                {
                    if (fl == floorsCount)
                    {
                        Console.Write($"L{fl}{room} ");
                    }
                    else if (fl % 2 == 0)
                    {
                        Console.Write($"O{fl}{room} ");
                    }
                    else if (fl % 2 != 0)
                    {
                        Console.Write($"A{fl}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
