using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());
            double worksDays = 0.9 * days;
            double overtime = overtimeWorkers * 2 * days;
            double workHours = Math.Floor(worksDays * 8 + overtime);

           if(hours <= workHours)
            {
                double d = workHours - hours;
                Console.WriteLine($"Yes!{d} hours left.");
            }
            else
            {
                double d = hours - workHours;
                Console.WriteLine($"Not enough time!{d} hours needed.");
            }

        }
    }
}
