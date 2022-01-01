using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countGroup1 = 0;
            int countGroup2 = 0;
            int countGroup3 = 0;
            int countGroup4 = 0;
            int countGroup5 = 0;

            for(int number = 1; number <= n; number ++)
            {
                int value = int.Parse(Console.ReadLine());
                if(value < 200)
                {
                    countGroup1++;
                }
                else if(value >= 200 && value <= 399)
                {
                    countGroup2++;
                }
                else if(value >= 400 && value <= 599)
                {
                    countGroup3++;
                }
                else if(value >= 600 && value <= 799)
                {
                    countGroup4++;
                }
                else if(value >= 800)
                {
                    countGroup5++;
                }
            }
            double percent1 = countGroup1 * 1.0 / n * 100;
            double percent2 = countGroup2 * 1.0 / n * 100;
            double percent3 = countGroup3 * 1.0 / n * 100;
            double percent4 = countGroup4 * 1.0 / n * 100;
            double percent5 = countGroup5 * 1.0 / n * 100;

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            Console.WriteLine($"{percent4:f2}%");
            Console.WriteLine($"{percent5:f2}%");
        }
    }
}
