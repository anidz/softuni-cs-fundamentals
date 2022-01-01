using System;

namespace _9.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsHome = double.Parse(Console.ReadLine());


            double sofiaWeekends = (48.0 - weekendsHome) * (3.0 / 4.0);

            double playSofia = holidays * (2.0 / 3.0);

            double playTotal = sofiaWeekends + playSofia + weekendsHome;

            if (year.Equals("leap"))
                playTotal += playTotal * 15 / 100;


            Console.WriteLine(Math.Floor(playTotal));
        }
    }
    }

