using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double numberAllFans = double.Parse(Console.ReadLine());
            string sector = "null";
            double secA = 0;
            double secB = 0;
            double secV = 0;
            double secG = 0;
            for (int i = 0; i < numberAllFans; i++)
            {
                sector = Console.ReadLine();
                if (sector == "A")
                {
                    secA += 1;
                }
                else if (sector == "B")
                {
                    secB += 1;
                }
                else if (sector == "V")
                {
                    secV += 1;
                }
                else if (sector == "G")
                {
                    secG += 1;
                }
            }
            secA = secA / numberAllFans * 100;
            secB = secB / numberAllFans * 100;
            secV = secV / numberAllFans * 100;
            secG = secG / numberAllFans * 100;
            double fansRelativeToTheStadium = numberAllFans / stadiumCapacity * 100;

            Console.WriteLine($"{secA:F2}%");
            Console.WriteLine($"{secB:F2}%");
            Console.WriteLine($"{secV:F2}%");
            Console.WriteLine($"{secG:F2}%");
            Console.WriteLine($"{fansRelativeToTheStadium:F2}%");
        }
    }
    }

