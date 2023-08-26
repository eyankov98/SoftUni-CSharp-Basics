using System;

namespace _04._Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gamer1 = Console.ReadLine();
            string gamer2 = Console.ReadLine();

            int totalGamer1 = 0;
            int totalGamer2 = 0;

            string command = Console.ReadLine();

            while (command != "End of game")
            {
                int card1 = int.Parse(command);
                int card2 = int.Parse(Console.ReadLine());

                if (card1 > card2)
                {
                    totalGamer1 += card1 - card2;
                }
                else if (card2 > card1)
                {
                    totalGamer2 += card2 - card1;
                }
                else
                {
                    while (true)
                    {
                        card1 = int.Parse(Console.ReadLine());
                        card2 = int.Parse(Console.ReadLine());

                        if (card1 > card2)
                        {
                            Console.WriteLine($"Number wars!");
                            Console.WriteLine($"{gamer1} is winner with {totalGamer1} points");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"Number wars!");
                            Console.WriteLine($"{gamer2} is winner with {totalGamer2} points");
                            return;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "End of game")
            {
                Console.WriteLine($"{gamer1} has {totalGamer1} points");
                Console.WriteLine($"{gamer2} has {totalGamer2} points");
            }
        }
    }
}
