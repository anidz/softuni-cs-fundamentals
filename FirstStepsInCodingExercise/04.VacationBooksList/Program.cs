using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            double totalTime = numberOfPages / pagesPerHour;
            double hoursPerDay = totalTime / numberOfDays;
            Console.WriteLine(hoursPerDay);
        }
    }
}
