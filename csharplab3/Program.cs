using System;

namespace csharplab3
{
    class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int dayTime;
                string tempDayTime="";
                Console.WriteLine("Введите время");
                dayTime = Convert.ToInt32(Console.ReadLine());
                if (dayTime >= 7 & dayTime <= 12)
                {
                    tempDayTime = $"{(DayTime)Enum.GetValues(typeof(DayTime)).GetValue(0)}";
                }
                if (dayTime >= 13 & dayTime <= 17)
                {
                    tempDayTime = $"{(DayTime)Enum.GetValues(typeof(DayTime)).GetValue(1)}";
                }
                if (dayTime >= 18 & dayTime <= 23)
                {
                    tempDayTime = $"{(DayTime)Enum.GetValues(typeof(DayTime)).GetValue(2)}";
                }
                if (dayTime >= 0 & dayTime <= 6)
                {
                    tempDayTime = $"{(DayTime)Enum.GetValues(typeof(DayTime)).GetValue(3)}";
                }
                if(dayTime < 0 || dayTime > 24)
                {
                    Console.WriteLine("Вы ввели неверное значение!");
                    break;
                }
                Console.WriteLine("Введите номер дня недели от 0 до 7");
                int weekId;
                string tempWeek = "";
                weekId = Convert.ToInt32(Console.ReadLine());
                if (weekId < 0 || weekId > 7)
                {
                    Console.WriteLine("Вы ввели неверное значение!");
                    break;
                }
                switch (weekId)
                {
                    case 0:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(0)}";
                        break;
                    case 1:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(1)}";
                        break;
                    case 2:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(2)}";
                        break;
                    case 3:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(3)}";
                        break;
                    case 4:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(4)}";
                        break;
                    case 5:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(5)}";
                        break;
                    case 6:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(6)}";
                        break;
                    case 7:
                        tempWeek = $"{(DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(7)}";
                        break;
                }

                Console.WriteLine($"Сейчас: {tempDayTime},{tempWeek}");
            }
        }
    }
}
