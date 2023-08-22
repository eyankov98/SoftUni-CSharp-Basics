using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookAnnie = Console.ReadLine();
            string book = Console.ReadLine();

            int countBooks = 0;

            while (book != "No More Books")
            {
                if (book == bookAnnie)
                {
                    Console.WriteLine($"You checked {countBooks} books and found it.");
                    return;
                }

                countBooks++;

                book = Console.ReadLine();
            }

            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {countBooks} books.");
        }
    }
}
