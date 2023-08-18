using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivingHour = int.Parse(Console.ReadLine());
            int arrivingMinutes = int.Parse(Console.ReadLine());

            int examTimeInMinutes = examHour * 60 + examMinutes;
            int arrivingTimeInMinutes = arrivingHour * 60 + arrivingMinutes;
            int timeDiference = Math.Abs(examTimeInMinutes - arrivingTimeInMinutes);
            string statment = "";
            int hourConver = 0;
            int minutesConvert = 0;

            if (examTimeInMinutes < arrivingTimeInMinutes)
            {
                statment = "Late";
                if (timeDiference >= 1 && timeDiference <= 59)
                {
                    Console.WriteLine(statment);
                    Console.WriteLine($"{timeDiference} minutes after the start");
                }
                else
                {
                    hourConver = timeDiference / 60;
                    minutesConvert = timeDiference % 60;
                    Console.WriteLine(statment);
                    Console.WriteLine($"{hourConver}:{minutesConvert:d2} hours after the start");
                }
            }
            else if (examTimeInMinutes >= arrivingTimeInMinutes && timeDiference <= 30)
            {
                statment = "On time";

                if (timeDiference > 0 && timeDiference <= 30)
                {
                    Console.WriteLine(statment);
                    Console.WriteLine($"{timeDiference} minutes before the start");
                }
                else
                {
                    Console.WriteLine(statment);
                }
            }
            else if (examTimeInMinutes > arrivingTimeInMinutes && timeDiference > 30)
            {
                statment = "Early";
                if (timeDiference <= 59)
                {
                    Console.WriteLine(statment);
                    Console.WriteLine($"{timeDiference} minutes before the start");
                }
                else
                {
                    hourConver = timeDiference / 60;
                    minutesConvert = timeDiference % 60;
                    Console.WriteLine(statment);
                    Console.WriteLine($"{hourConver}:{minutesConvert:d2} hours before the start");
                }
            }
        }
    }
}
