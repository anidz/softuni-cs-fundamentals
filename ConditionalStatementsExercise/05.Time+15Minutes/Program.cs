using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHour = int.Parse(Console.ReadLine());
            int currentMinutes = int.Parse(Console.ReadLine());

            int currentTimeInMinutes = currentHour * 60 + currentMinutes;
            int finalTimeInMinutes = currentTimeInMinutes + 15;
            int finalHour = finalTimeInMinutes / 60;
            int finalMinutes = finalTimeInMinutes % 60;
            if(finalHour == 24)
            {
                finalHour = 0;
                Console.WriteLine($"{finalHour}:{finalMinutes:D2}");
            }
            else
            {
                Console.WriteLine($"{finalHour}:{finalMinutes:D2}");
            }
        }
    }
}
