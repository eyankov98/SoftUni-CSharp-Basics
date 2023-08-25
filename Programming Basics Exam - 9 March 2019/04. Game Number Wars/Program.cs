using System;

namespace _04._Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            string command = string.Empty;

            int firstPlayerCardNumber = 0;
            int secondPlayerCardNumber = 0;

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            int firstPlayerPointsSum = 0;
            int secondPlayerPointsSum = 0;

            while ((command = Console.ReadLine()) != "End of game")
            {
                firstPlayerCardNumber = int.Parse(command);
                secondPlayerCardNumber = int.Parse(Console.ReadLine());

                if (firstPlayerCardNumber > secondPlayerCardNumber)
                {
                    firstPlayerPoints = firstPlayerCardNumber - secondPlayerCardNumber;
                    firstPlayerPointsSum += firstPlayerPoints;
                }

                else if (firstPlayerCardNumber < secondPlayerCardNumber)
                {
                    secondPlayerPoints = secondPlayerCardNumber - firstPlayerCardNumber;
                    secondPlayerPointsSum += secondPlayerPoints;
                }

                else if (firstPlayerCardNumber == secondPlayerCardNumber)
                {
                    Console.WriteLine("Number wars!");
                    firstPlayerCardNumber = int.Parse(Console.ReadLine());
                    secondPlayerCardNumber = int.Parse(Console.ReadLine());

                    if (firstPlayerCardNumber > secondPlayerCardNumber)
                    {
                        firstPlayerPoints = firstPlayerCardNumber - secondPlayerCardNumber;
                        Console.WriteLine($"{firstPlayerName} is winner with {firstPlayerPoints} points");
                        return;
                    }
                    else if (firstPlayerCardNumber < secondPlayerCardNumber)
                    {
                        secondPlayerPoints = secondPlayerCardNumber - firstPlayerCardNumber;
                        Console.WriteLine($"{secondPlayerName} is winner with {secondPlayerPoints} points");
                        return;
                    }
                }

                firstPlayerPoints = 0;
                secondPlayerPoints = 0;
            }

            Console.WriteLine($"{firstPlayerName} has {firstPlayerPointsSum} points");
            Console.WriteLine($"{secondPlayerName} has {secondPlayerPointsSum} points");
        }
    }
}
